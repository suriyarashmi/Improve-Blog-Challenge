using System.Collections.Generic;
using System.Threading.Tasks;
using SimpleBlog.FrontEnd.Models;

namespace SimpleBlog.FrontEnd.ViewModels
{
    public class PostDetailsViewModel {
        public Post Post { get; set; }

        public List<Comment> Comments { get; set; }
        public CommentsCount CommentsCount {get; set;}
        public ColorGroup colourGroup{get;set;}
        public PostDetailsViewModel(){
            foreach (string Comment in Comments )
{
CommentsCount++;
}
}
    }
}