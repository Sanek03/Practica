//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KruzhokIS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Расписание
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Расписание()
        {
            this.Сотрудник1 = new HashSet<Сотрудник1>();
        }
    
        public int id_расписания { get; set; }
        public int id_сотрудника { get; set; }
        public int id_кружка { get; set; }
        public string День_недели { get; set; }
        public string Кабинет { get; set; }
    
        public virtual Кружок Кружок { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Сотрудник1> Сотрудник1 { get; set; }
    }
}
