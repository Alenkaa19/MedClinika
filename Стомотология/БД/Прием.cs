//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Стомотология.БД
{
    using System;
    using System.Collections.Generic;
    
    public partial class Прием
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Прием()
        {
            this.Услуги = new HashSet<Услуги>();
        }
    
        public int КодПриема { get; set; }
        public System.DateTime ДатаПриема { get; set; }
        public string Прием1 { get; set; }
        public decimal Стоимость { get; set; }
        public int КодТалона { get; set; }
        public int КодДиагноза { get; set; }
    
        public virtual Диагноз Диагноз { get; set; }
        public virtual Талон Талон { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Услуги> Услуги { get; set; }
    }
}
