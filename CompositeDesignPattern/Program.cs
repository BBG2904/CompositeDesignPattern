// See https://aka.ms/new-console-template for more information
using CompositeDesignPattern;
// From Client same display method is used for calling composite class folder and leaf class file. 
// Leaf which cannot be divided again. 
//composite can be divided into mutiple parts.

var file1 = new CompositeDesignPattern.File("Sample.txt");
file1.Display();
var file2 = new CompositeDesignPattern.File("Random.txt");
file2.Display();

var folder1 = new Folder("Folder1");
folder1.AddFile(file1);
folder1.AddFile(file2);
folder1.RemoveFile(file1);

folder1.Display();

var folder2 = new Folder("Folder2");
folder2.AddFile(file1);
folder2.AddFile(file2);
//folder2.RemoveFile(file1);

folder2.Display();


