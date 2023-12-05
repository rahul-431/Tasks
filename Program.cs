// See https://aka.ms/new-console-template for more information
using Task;

Console.WriteLine("This is for first condition;");
Director director=new Director();
IProfileBuilder profileBuilderA=new ProfileA();
director.construct(profileBuilderA);
Profile profile=profileBuilderA.GetProfile();
profile.Display();

Console.WriteLine("This is for Second condition;");
// Director director=new Director();
IProfileBuilder profileBuilderB=new ProfileB();
director.construct(profileBuilderB);
Profile profile1=profileBuilderB.GetProfile();
profile1.Display();



