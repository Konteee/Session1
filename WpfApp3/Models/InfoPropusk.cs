//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class InfoPropusk
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InfoPropusk()
        {
            this.Obshii = new HashSet<Obshii>();
        }
    
        public int Id { get; set; }
        public System.DateTime DateS { get; set; }
        public System.DateTime DatePo { get; set; }
        public int IdGoalVisiting { get; set; }
    
        public virtual Visiting Visiting { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Obshii> Obshii { get; set; }
    }
}