using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog;
using Generics;

namespace InterviewPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            //StaticClass.IncrementSize();
            //StaticClass.IncrementSize();
            Linq linq = new Linq();
            linq.DoStuff();

            //BlogPost.StaticMethod();

            //MyStruct structObj = new MyStruct(10);
            //Shape[] shapes =
            //{
            //    new Square(5, "Square #1"),
            //    new Circle(3, "Circle #1"),
            //    new Rectangle( 4, 5, "Rectangle #1")
            //};
            //Shape shape = new Rectangle(10, 9, "rect 2");
            //System.Console.WriteLine(shape);
            //System.Console.WriteLine("Shapes Collection");
            //foreach (Shape s in shapes)
            //{
            //    System.Console.WriteLine(s);
            //    s.ShowShape(s);
            //}

            //Rectangle rect = new Rectangle(1, 1, "1");
            //shape = rect;
            //rect = (Rectangle)shape;
            
            //BlogPost post = new BlogPost();
            //post.Post = "this is the post";
            //Settings setting = new Settings();
            //Action<BlogPost> settingHandler = post.ApplyBackground;
            //settingHandler += post.ApplyFont;
            //settingHandler += ApplyBold;
            //setting.ProcessSettings(post, settingHandler);
            Console.ReadKey();
            //setting.ProcessSettings(blog,)
        }

        public static void ApplyBold(BlogPost post)
        {
            Console.WriteLine("Bold applied");
        }

        public static void Generics()
        {
            GenericList<int> gList = new GenericList<int>();
            gList.Add(7);
            gList.Add(17);
            gList.Add(32);
            gList.Add(2);
            gList.PrintList();
            
        }

        public static void ExtensionMethods()
        {
            BlogPost blog = new BlogPost();
            blog.Post = "this is the post";
            Console.WriteLine(blog.GetSummary(2));
            
        }
    }

    public static class BlogPostsExtension
    {
        public static string GetSummary(this BlogPost post, int numberOfWords)
        {
            string summary="";
            string [] postWords;
            if (numberOfWords == 0)
                summary = "...";
            else
            {
                postWords =  post.Post.Split(' ');

                summary = string.Join(" ", postWords.Take(2));
                summary += "...";
            }
            return summary;
        }
    }
}
