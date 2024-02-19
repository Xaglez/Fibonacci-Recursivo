using System.Data;

class Program{
    public static void Main(string[] args){
        Console.WriteLine("Insira o temanho do fibonacci");
        try{
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++){
            Console.Write(" "+ fibo(i));
        }

        }catch (Exception ex){
            Console.WriteLine("Insira um número válido, Erro: " + ex.Message);
        }
    }

    public static int fibo(int n){
        if (n == 0){
            return 0;
        }
        else if(n == 1){
            return 1;
        }
        else{
            return fibo(n -1) + fibo(n - 2);
        }
    }
}