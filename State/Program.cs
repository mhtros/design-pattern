using State.Documents;
using State.Users;

var admin = new User("John", (int) UserPrivileges.Administrator);
var basic = new User("Paul", (int) UserPrivileges.Basic);

admin.ReviewDocumentHandler += Review;

var document = new Document("A Great Document", "Very lazy document!");
var document2 = new Document("Greetings", "Sup bro!");

document.Publish(basic);
document.Publish(basic);
document.Publish(admin);
document.Content = "This is a very well structured document with a lot information!";
document.Publish(basic);
document.Publish(admin);
document.Publish(admin);
Console.WriteLine("==============");
document2.Publish(admin);

void Review(object? sender, ReviewDocumentArgs documentArgs) =>
    documentArgs.Document.PassReview = documentArgs.Document.Content.Length >= 20;