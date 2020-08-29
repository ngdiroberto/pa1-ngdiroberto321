using System;
using System.Collections.Generic;

namespace pa1_ngdiroberto321
{
    public class Post : IComparable<Post> 
    {
        public string ID{get; set;} 
        public string PostText{get; set;}
        public string Date{get; set;}

        public string ToString(){
            return this.ID + "\t" + this.PostText + "\t" + this.Date;
        }

        public int CompareTo(Post temp){
            return this.Date.CompareTo(temp.Date);
        }
    }
}