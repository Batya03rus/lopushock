//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lopus
{
    using System;
    using System.Collections.Generic;
    
    public partial class Продукция
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Продукция()
        {
            this.Заявка = new HashSet<Заявка>();
            this.Материал = new HashSet<Материал>();
            this.Производство = new HashSet<Производство>();
        }
    
        public int ID { get; set; }
        public Nullable<int> ID_производства { get; set; }
        public Nullable<int> Количество { get; set; }
        public Nullable<decimal> Стоимость { get; set; }
        public Nullable<System.DateTime> Время_производства { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Заявка> Заявка { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Материал> Материал { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Производство> Производство { get; set; }
    }
}
