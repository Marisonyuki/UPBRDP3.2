//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UPBRDP3._2
{
    using System;
    using System.Collections.Generic;
    
    public partial class GameIndustry
    {
        public int ID_GI { get; set; }
        public int Worker_ID { get; set; }
        public int Project_ID { get; set; }
    
        public virtual Project Project { get; set; }
        public virtual Worker Worker { get; set; }
    }
}
