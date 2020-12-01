﻿using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class ListTitlePreOrder
    {
        [Key]
        [DisplayName("Mã Đặt Trước")]
        public int IdListTitlePreOrder { get; set; }
        public virtual Customer Customer { get; set; }
        [DisplayName("Mã Khách Hàng")]
        public int? IdCustomer { get; set; }
        public virtual Title Title { get; set; }
        [DisplayName("Mã Tiêu Đề")]
        public int? IdTitle { get; set; }
        [DisplayName("Số Lượng Đặt Trước")]
        public int? NumberOfDisk { get; set; }
        [DisplayName("Trạng Thái Đơn Đặt Trước")]
        public string StatusProcess { get; set; }
        public ICollection<DetailPreOrder> DetailPreOrders { get; set; }
    }
}
