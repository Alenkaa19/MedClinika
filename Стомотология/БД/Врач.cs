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
    
    public partial class Врач
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Врач()
        {
            this.Талон = new HashSet<Талон>();
        }
    
        public int КодВрача { get; set; }
        public string Фамилия { get; set; }
        public string Имя { get; set; }
        public string Отчество { get; set; }
        public string Специальность { get; set; }
        public string Категория { get; set; }
        public Nullable<int> КодПользователя { get; set; }
        public string Расписание { get; set; }
    
        public virtual Пользователь Пользователь { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Талон> Талон { get; set; }
    }
}
