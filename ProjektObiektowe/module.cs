//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjektObiektowe
{
    using System;
    using System.Collections.ObjectModel;
    
    public partial class module
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public module()
        {
            this.modules1 = new ObservableCollection<module>();
            this.students_modules = new ObservableCollection<students_modules>();
        }
    
        public int module_id { get; set; }
        public string module_name { get; set; }
        public byte no_of_hours { get; set; }
        public Nullable<int> lecturer_id { get; set; }
        public Nullable<int> preceding_module { get; set; }
        public string department { get; set; }
    
        public virtual department department1 { get; set; }
        public virtual lecturer lecturer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableCollection<module> modules1 { get; set; }
        public virtual module module1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableCollection<students_modules> students_modules { get; set; }
    }
}
