//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WEB_API_CRUD_Logics.Models
{
    using System;
    using System.Collections.Generic;
    /* 
     public partial class ForumComment
     {
         public int CommentID { get; set; }
         public Nullable<int> UserID { get; set; }
         public Nullable<int> PostID { get; set; }

         public virtual Comment Comment { get; set; }
         public virtual ForumPost ForumPost { get; set; }
         public virtual User User { get; set; }
     }*/
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class ForumComment
    {
        [Key]
        public int CommentID { get; set; }
        // Primary Key
        public int? UserID { get; set; }
        public int? PostID { get; set; }

        [Required]
        [ForeignKey("CommentID")]
        public virtual Comment Comment { get; set; }
        [ForeignKey("PostID")]
        public virtual ForumPost ForumPost { get; set; }

        [Required]
        [ForeignKey("UserID")]
        public virtual User User { get; set; }
    }
}
