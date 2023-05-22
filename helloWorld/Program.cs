// See https://aka.ms/new-console-template for more information

//dotnet new console --use-program-main  for old style
Console.WriteLine("Welcome to calculator");
int[,] mat = createMatrix();
int x =0;
Console.WriteLine(mat[1,1]);




static int[,] createMatrix(){
    int[,] mat = new int[2,2];
    mat[0,0] = 1;
    mat[0,1] = 2;
    mat[1,0] = 3;
    mat[1,1] = 4;
    return mat;
    



}
