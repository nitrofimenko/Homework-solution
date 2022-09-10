using L06_21;

Random rnd = new Random();

int[] test = new int[rnd.Next(10, 20)];
test.GetRandom(10, 99);
test.Show();

test.Sort();
test.Show();

test.Sort("Descending");
test.Show();
