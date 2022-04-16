
using BinarySearchTrees;

Tree binaryTree = new Tree();
binaryTree.Insert(7);
binaryTree.Insert(4);
binaryTree.Insert(9);
binaryTree.Insert(1);
binaryTree.Insert(6);
binaryTree.Insert(8);
binaryTree.Insert(10);

Console.WriteLine("Done");
var rootnode = binaryTree.ReturnRoot();
binaryTree.PreOrderTraverse(rootnode);
Console.WriteLine("***************************************");
binaryTree.InOrderTraverse(rootnode);
Console.WriteLine("***************************************");
binaryTree.PostOrderTraverse(rootnode);
