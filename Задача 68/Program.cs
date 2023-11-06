// Задача 68: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
class Program {
  static int akk(int m,int n){
    if (m==0) {
      if (n==0) return 1;
      else return n+1;
    } else if (n==0)
      return akk(m-1, 1); 
      else 
      return akk (m-1,akk(m,n-1)); 
  }
  static void Main (string[] args) {
    Console.Write ("Введите m: ");
    int m = Convert.ToInt32 (Console.ReadLine ());
    Console.Write ("Введите n: ");
    int n = Convert.ToInt32 (Console.ReadLine ());
    int result = akk (m,n);
    Console.WriteLine ($"A({m},{n})={result}");
  }
}