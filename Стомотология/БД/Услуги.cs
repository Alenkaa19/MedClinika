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
    
    public partial class Услуги
    {
        public int КодУслуги { get; set; }
        public string Услуга { get; set; }
        public int КодПриема { get; set; }
    
        public virtual Прием Прием { get; set; }
    }
}
