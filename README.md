# Dự án Web Phụ Kiện Cannabis
# 🚀 Giới thiệu
Đây là dự án Website bán phụ kiện Cannabis được phát triển với mục tiêu phục vụ thị trường phụ kiện chuyên dụng. Dự án bao gồm:
Backend: ASP.NET Core API (.NET 8), code-first Entity Framework
Frontend: Angular 18
Cơ sở dữ liệu: SQL Server
UI/UX: Tối ưu cho trải nghiệm mua sắm hiện đại, thân thiện
# 🏗️ Kiến trúc hệ thống
Tầng Backend (Cannabis.Server/):
DAL/Models: các thực thể bảng (Entity)
DTOs/: các lớp truyền dữ liệu
Enums/: khai báo vai trò, trạng thái...
Repositories/: truy vấn dữ liệu
Services/: xử lý nghiệp vụ
Helpers/: tiện ích dùng chung
Middlewares/: xử lý lỗi, JWT...
Controllers/: định nghĩa các API endpoint
Tầng Frontend (Cannabis.Client/):
Angular 18: sử dụng standalone components, reactive forms
State quản lý bằng RxJS hoặc SignalR nếu cần realtime
Giao diện: có thể tùy chỉnh Tailwind hoặc Angular Material
🎯 Chức năng chính
👤 Người dùng (Customer)
Đăng ký, đăng nhập, cập nhật tài khoản

Tìm kiếm, xem chi tiết sản phẩm

Thêm giỏ hàng, đặt hàng, chọn phương thức thanh toán và giao hàng

Xem lịch sử đơn hàng, theo dõi đơn, đánh giá sản phẩm

🧑‍💼 Nhân viên (Employee)
Xử lý đơn hàng

Cập nhật trạng thái đơn

In hóa đơn, theo dõi vận chuyển

(Tùy hệ thống có thể chỉnh sửa sản phẩm hoặc không)

👑 Quản trị viên (Admin)
Quản lý sản phẩm, danh mục, thương hiệu, nhà lai tạo

Quản lý đơn hàng toàn bộ hệ thống

Quản lý tài khoản nhân viên / người dùng

Tích hợp thanh toán, vận chuyển

Quản lý mã giảm giá, khuyến mãi

Xem báo cáo thống kê
# 📐 Tài liệu UML (Use Case) https://drive.google.com/file/d/1fc2AjrNZ7O_G2MsOakA-wGHJSi_Pm4u-/view?usp=drive_link
# 📌 Ghi chú phát triển
Sử dụng mô hình phân quyền bằng Role + Middleware

JWT để xác thực, refresh token