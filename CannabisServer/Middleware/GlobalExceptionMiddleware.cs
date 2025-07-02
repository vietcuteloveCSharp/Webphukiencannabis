﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Middleware
{
	public class GlobalExceptionMiddleware
	{
		private readonly RequestDelegate _next;
		public GlobalExceptionMiddleware(RequestDelegate next)
		{
			this._next = next;
		}
		public async Task InvokeAsync(HttpContext context)
		{
			try
			{
				await _next(context); //tiếp tục pipieline
			}
			catch (Exception ex)
			{
				await HandleExceptionAsync(context, ex); // xử lý exception
			}
		}

		private static Task HandleExceptionAsync(HttpContext context, Exception ex)
		{
			//phân loại lỗi
			var code = HttpStatusCode.InternalServerError;
			switch(ex)
			{
				case KeyNotFoundException:
					code = HttpStatusCode.NotFound;
					break;
				case UnauthorizedAccessException:
					code = HttpStatusCode.Unauthorized;
					break;
				case ArgumentException:
					code = HttpStatusCode.BadRequest;
					break;
				case InvalidOperationException:
					code = HttpStatusCode.BadRequest;
					break;
				
			}
			var result = JsonSerializer.Serialize(new
			{
				status=(int)code,
				error = ex.Message,
			});
			context.Response.ContentType = "application/json"; //đặt kiểu dữ liệu trả về
			context.Response.StatusCode = (int)code; //đặt mã trạng thái trả về
			return context.Response.WriteAsync(result); //trả về kết quả
		}
	}
}
