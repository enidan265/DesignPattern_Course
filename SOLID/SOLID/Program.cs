
using SOLID;

ITree tree1 = TreeFactory.GetTree(TreeType.TANNE);
tree1.DrawTree(10, 20, 5);

ITree tree2 = TreeFactory.GetTree(TreeType.TANNE);
tree1.DrawTree(33, 22, 3);

ITree tree3 = TreeFactory.GetTree(TreeType.BIRKE);
tree1.DrawTree(15, 10, 6);

ITree tree4 = TreeFactory.GetTree(TreeType.BIRKE);
tree1.DrawTree(50, 220, 8);

ITree tree5 = TreeFactory.GetTree(TreeType.TANNE);
tree1.DrawTree(120, 240, 5);

