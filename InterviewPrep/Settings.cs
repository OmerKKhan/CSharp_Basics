using Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    public class Settings
    {
        public void ProcessSettings(BlogPost post, Action<BlogPost> settingHandler)
        {
            settingHandler(post);
        }

    }
}
