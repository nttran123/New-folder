//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EndToEnd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Topic
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Topic()
        {
            this.Enrollments = new HashSet<Enrollment>();
        }
    
        public int TopicID { get; set; }
        [Display(Name = "Name")]
        [StringLength(20, ErrorMessage = "The name must be under 20 characters.")]
        public string TopicName { get; set; }
        [Display(Name = "Description")]
        [StringLength(20, ErrorMessage = "The description must be under 20 characters.")]
        public string TopicDescription { get; set; }
        public Nullable<int> CourseID { get; set; }
        public Nullable<int> TrainerID { get; set; }
    
        public virtual Course Course { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual Trainer Trainer { get; set; }
    }
}
