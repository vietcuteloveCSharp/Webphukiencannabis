using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum.EnumableClass
{
    public static class EnumableClass
    {
        public enum ECoolingType
        {
            Active,
            Passive
        }
        public enum ECustomerStatus
        {
            Active,   // Đang hoạt động
            Inactive,   // Không hoạt động
            Suspended,  // Đã bị khóa
            Deleted,    // Đã xóa (logic delete)
            Anonymous   // Người dùng ẩn danh
        }
        public enum EOrderSatus
        {
            Pending,         // Đang chờ xử lý
            Confirmed,       // Đã xác nhận
            Processing,      // Đang xử lý
            Shipped,         // Đã giao cho đơn vị vận chuyển
            Delivered,       // Đã giao hàng thành công
            Canceled,        // Đã hủy
            Returned,        // Khách hàng đã trả lại hàng
            Failed           // Giao hàng thất bại
        }
        public enum EPowerSypplyType
        {
            AC,
            DC,
            Battery
        }
        public enum EDiscountType
        {
            Percent,
            Fixed
        }
        public enum ERoleName
        {
            Admin = 0,
            Employee = 1
        }
        public enum EDifficulty
        {
            Easy,
            Medium,
            Hard
        }
        public enum EStrainType
        {

            Indica,
            Sativa,
            Hybrid

        }
        public enum ESellerSatus
        {
            Active,
            NonActive
        }
        public enum ESpectrumType
        {
            FullSpectrum,
            RedBlue,
            WarmWhite,
            CoolWhite,
            Uv
        }
        public enum EProductType
        {
            Growlight,Seed,Growtent,CarbonFilter,Nutrient, Dehumidifier

        }
    }
}
