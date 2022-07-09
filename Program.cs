using Blog.Data;
using Blog.Models;

using var context = new BlogDataContext();

//context.Users.Add(new User
//{
//    Name = "André Baltiaeri",
//    Slug = "andrebaltieria",
//    Email = "andre@balta.iao",
//    Bio = "9x Microsoft MVaP",
//    Image = "https://balta.ioa",
//    PasswordHash = "12309845a7"
//});

//var user = context.Users.FirstOrDefault();

//var post = new Post
//{
//    Author = user,
//    Category = new Category { Name = "ASFDAS", Slug = "DASFGS"},
//    Body = "<p>Hello woarld</p>",
//    Slug = "comecando-comaa-ef-core",
//    Summary = "Neste artigaao vamos aprender EF core",
//    Title = "Começando comaaa EF Core",
//    CreateDate = DateTime.Now,
//};

//context.Posts.Add(post);

//context.SaveChanges();
