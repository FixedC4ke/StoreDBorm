//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace laba10subd
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int ID { get; set; }
        public Nullable<int> ClientID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> Amount { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<int> DeliveryID { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Delivery Delivery { get; set; }
        public virtual Product Product { get; set; }
    }
}
