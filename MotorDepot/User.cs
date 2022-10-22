//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MotorDepot
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.FeedbackDriver = new HashSet<FeedbackDriver>();
            this.FeedbackDriver1 = new HashSet<FeedbackDriver>();
            this.HistoryClientDriver = new HashSet<HistoryClientDriver>();
            this.RequestDriver = new HashSet<RequestDriver>();
        }
    
        public int Id { get; set; }

        [Required(ErrorMessage = "Заполните ФИО!")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Заполните логин!")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Заполните пароль!")]
        public string Password { get; set; }
        public Nullable<System.DateTime> DayOfBirth { get; set; }
        public string Gender { get; set; }
        public Nullable<int> IdCar { get; set; }
        public byte[] Image { get; set; }
    
        public virtual Car Car { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FeedbackDriver> FeedbackDriver { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FeedbackDriver> FeedbackDriver1 { get; set; }
        public virtual Gender Gender1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoryClientDriver> HistoryClientDriver { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequestDriver> RequestDriver { get; set; }
    }
}
