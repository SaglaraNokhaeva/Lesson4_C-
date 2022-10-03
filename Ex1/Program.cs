String[,]table=new string[2,5];
table[1,2]="слово";
for (int rows=0;rows<2;rows++)
{
    for(int colums=0;colums<5;colums++)
    {
        Console.WriteLine($"-{table[rows,colums]}-");
    }
}

void PrintArr(int[,]matr)
{
    
    for (int i=0;i<matr.GetLength(0);i++)
    {
        for(int j=0;j<matr.GetLength(1);j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}

void FillArr(int[,]matr)
{
    
    for (int i=0;i<matr.GetLength(0);i++)
    {
        for(int j=0;j<matr.GetLength(1);j++)
        {
            matr[i,j]=new Random().Next(1,10);
        }
        Console.WriteLine();
    }
}


int[,]matrix=new int[3,4];
PrintArr(matrix);
FillArr(matrix);
PrintArr(matrix);