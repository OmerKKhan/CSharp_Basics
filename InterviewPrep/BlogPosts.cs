using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    public class BlogPost
    {
        private string post;
        private int postNumber;

        public BlogPost()
        {

        }

        public string Post
        {
            get{return post;}
            set { post = value; }
        }

        public int PostNumber
        {
            get
            {
                return postNumber;
            }
            set { postNumber = value; }
        }

        public void ApplyFont(BlogPost post)
        {
            Console.WriteLine("Font applied");
        }

        public void ApplyBackground(BlogPost post)
        {
            Console.WriteLine("Background applied");
        }

        public static void StaticMethod()
        {
            Console.WriteLine("Static method called from non static class BlogPost");
        }
    }
}
