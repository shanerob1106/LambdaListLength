// See https://aka.ms/new-console-template for more information

List<int> num = new List<int> { 1, 3, 4, 5, 7, 9};
int length = 4;

Func<IList<int>, int, bool> isSizeTooBig = (list, length) => num.Count > length;

bool isLong = isSizeTooBig(num, length);

Console.WriteLine("Too long?: " + isLong);