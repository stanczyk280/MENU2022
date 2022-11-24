///* 
// * File:   main.c
// * Author: Szymon Smiga
// *
// * Created on December 11, 2017, 8:07 PM
// */

//#include <stdio.h>
//#include <stdlib.h>

//void init(unsigned int n, double** A, double* b)
//{

//    if (n == 3)
//    {
//        A[0][0] = 2.0;
//        A[0][1] = 2.0;
//        A[0][2] = 6.0;

//        A[1][0] = 2.0;
//        A[1][1] = 1.0;
//        A[1][2] = 7.0;

//        A[2][0] = -2.0;
//        A[2][1] = -6.0;
//        A[2][2] = -7.0;

//        b[0] = 4.0;
//        b[1] = 6.0;
//        b[2] = -1.0;

//        //    A[0][0] =  1.0; 
//        //    A[0][1] =  2.0; 
//        //    A[0][2] =  3.0; 

//        //    A[1][0] =  4.0; 
//        //    A[1][1] =  3.0; 
//        //    A[1][2] =  -1.0;     

//        //    A[2][0] = 1.0; 
//        //    A[2][1] =  -1.0; 
//        //    A[2][2] =  1.0;                 

//        //    b[0] =  14.0;
//        //    b[1] =  7.0;
//        //    b[2] =  2.0;     

//        //    A[0][0] =  4.0; 
//        //    A[0][1] =  1.0; 
//        //    A[0][2] =  3.0; 

//        //    A[1][0] =  1.0; 
//        //    A[1][1] =  4.0; 
//        //    A[1][2] =  1.0;     

//        //    A[2][0] =  2.0; 
//        //    A[2][1] =  3.0; 
//        //    A[2][2] =  2.0;                 

//        //    b[0] =  2.0;
//        //    b[1] =  1.0;
//        //    b[2] =  4.0;        

//    }
//    else if (n == 4)
//    {

//        A[0][0] = 4.0;
//        A[0][1] = -2.0;
//        A[0][2] = 4.0;
//        A[0][3] = -2.0;

//        A[1][0] = 3.0;
//        A[1][1] = 1.0;
//        A[1][2] = 4.0;
//        A[1][3] = 2.0;

//        A[2][0] = 2.0;
//        A[2][1] = 4.0;
//        A[2][2] = 2.0;
//        A[2][3] = 1.0;

//        A[3][0] = 2.0;
//        A[3][1] = -2.0;
//        A[3][2] = 4.0;
//        A[3][3] = 2.0;

//        b[0] = 8.0;
//        b[1] = 7.0;
//        b[2] = 10.0;
//        b[3] = 2.0;

//    }
//    else if (n == 5)
//    {

//        A[0][0] = -1.0;
//        A[0][1] = 2.0;
//        A[0][2] = -3.0;
//        A[0][3] = 3.0;
//        A[0][4] = 5.0;

//        A[1][0] = 8.0;
//        A[1][1] = 0.0;
//        A[1][2] = 7.0;
//        A[1][3] = 4.0;
//        A[1][4] = -1.0;

//        A[2][0] = -3.0;
//        A[2][1] = 4.0;
//        A[2][2] = -3.0;
//        A[2][3] = 2.0;
//        A[2][4] = -2.0;

//        A[3][0] = 8.0;
//        A[3][1] = -3.0;
//        A[3][2] = -2.0;
//        A[3][3] = 1.0;
//        A[3][4] = 2.0;

//        A[4][0] = -2.0;
//        A[4][1] = -1.0;
//        A[4][2] = -6.0;
//        A[4][3] = 9.0;
//        A[4][4] = 0.0;



//        b[0] = 56.0;
//        b[1] = 62.0;
//        b[2] = -10.0;
//        b[3] = 14.0;
//        b[4] = 28.0;



//    }
//    else
//    {
//        printf("Error!\n Exit!!!");
//        exit(-1);
//    }
//}

//void printArr(unsigned int n, double** A)
//{
//    int i, j;

//    for (i = 0; i < n; i++)
//    {
//        for (j = 0; j < n; j++)
//            printf("%lf ", A[i][j]);

//        printf("\n");
//    }

//}

//void gauss(unsigned int n, double** A, double* x, double* b)
//{
//    int i, j, k;
//    double tmp;


//    for (i = 0; i < n; i++)
//    { // petla po diagonali
//        for (j = 0; j < n; j++)
//        { //petla po kolumnie
//            if (j > i)
//            {
//                tmp = A[j][i] / A[i][i];
//                for (k = i; k < n + 1; k++) // petla po kolumnach 
//                    if (k != n)
//                        A[j][k] = A[j][k] - tmp * A[i][k];
//                    else
//                        b[j] = b[j] - tmp * b[i];
//            }
//        }

//        //printArr(n, A);
//        //  printf("\n"); 

//    }

//    for (i = n - 1; i >= 0; i--)
//    {
//        tmp = 0.0;
//        for (j = i; j <= n - 1; j++)
//            tmp += A[i][j] * x[j];

//        x[i] = (b[i] - tmp) / A[i][i];
//    }

//}


//void gaussJor(unsigned int n, double** A, double* x, double* b)
//{
//    int i, j, k;
//    double tmp;


//    for (i = 0; i < n; i++)
//    { // petla po diagonali
//        for (j = 0; j < n; j++)
//        { //petla po kolumnie
//            if (j != i)
//            {
//                tmp = A[j][i] / A[i][i];
//                for (k = 0; k < n + 1; k++) // petla po kolumnach 
//                    if (k != n)
//                        A[j][k] = A[j][k] - tmp * A[i][k];
//                    else
//                        b[j] = b[j] - tmp * b[i];
//            }
//        }



//    }

//    for (i = n - 1; i >= 0; i--)
//    {
//        tmp = 0.0;
//        for (j = i; j <= n - 1; j++)
//            tmp += A[i][j] * x[j];

//        x[i] = (b[i] - tmp) / A[i][i];
//    }

//}



//void matMul(unsigned int n, double** A, double** B, double** C)
//{
//    unsigned int i, j, k;
//    double sum;

//    for (i = 0; i < n; i++)
//        for (j = 0; j < n; j++)
//            C[i][j] = 0;

//    for (i = 0; i < n; i++)
//    {
//        for (j = 0; j < n; j++)
//        {
//            for (k = 0; k < n; k++)
//            {
//                C[i][j] += A[i][k] * B[k][j];
//            }
//        }
//    }

//}




//void LUdecomp(unsigned int n, double** A, double** L, double** U)
//{
//    int i, j, k;
//    double tmp;

//    for (i = 0; i < n; i++)
//    {
//        for (j = 0; j < n; j++)
//            U[i][j] = A[i][j];
//        L[i][i] = 1.0;
//    }

//    for (i = 0; i < n; i++)
//    { // petla po diagonali
//        for (j = 0; j < n; j++)
//        { //petla po kolumnie
//            if (j > i)
//            {
//                tmp = U[j][i] / U[i][i];
//                L[j][i] = tmp;
//                for (k = 0; k < n + 1; k++) // petla po kolumnach 
//                    U[j][k] = U[j][k] - tmp * U[i][k];

//            }
//        }

//    }

//    printArr(n, L);
//    printf("\n");

//    printArr(n, U);
//    printf("\n");
//}

//void solveLU(unsigned int n, double** A, double* x, double* b)
//{
//    double* y, **L, **U;
//    int i, j;
//    double tmp;
//    //
//    L = (double**)calloc(n, sizeof(double*));
//    U = (double**)calloc(n, sizeof(double*));
//    //
//    y = (double*)calloc(n, sizeof(double));

//    //    
//    for (i = 0; i < n; i++)
//    {
//        L[i] = (double*)calloc(n, sizeof(double));
//        U[i] = (double*)calloc(n, sizeof(double));
//    }

//    LUdecomp(n, A, L, U);

//    //Ax = b
//    //LUx = b => Ly = b | Ux = y

//    //solve Ly = b

//    y[0] = b[0];
//    //  printf("%lf\n", y[0]);
//    for (i = 1; i < n; i++)
//    {
//        tmp = 0.0;
//        for (j = 0; j < i; j++)
//            tmp += L[i][j] * y[j];

//        y[i] = (b[i] - tmp);
//        // printf("%lf\n", y[i]);
//    }

//    //solve Ux = y          
//    for (i = n - 1; i >= 0; i--)
//    {
//        tmp = 0.0;
//        for (j = i; j < n; j++)
//            tmp += U[i][j] * x[j];

//        x[i] = (y[i] - tmp) / U[i][i];
//    }

//    for (i = 0; i < n; i++)
//    {
//        //     free(L[i]);free(U[i]);
//    }

//    free(y); free(L); free(U);

//}

////determinant
//double det(unsigned int n, double** A)
//{
//    double** L, **U;
//    int i, j;
//    double tmp;
//    //
//    L = (double**)calloc(n, sizeof(double*));
//    U = (double**)calloc(n, sizeof(double*));
//    //    
//    for (i = 0; i < n; i++)
//    {
//        L[i] = (double*)calloc(n, sizeof(double));
//        U[i] = (double*)calloc(n, sizeof(double));
//    }

//    LUdecomp(n, A, L, U);

//    tmp = 1.0;
//    for (i = 0; i < n; i++)
//    {
//        tmp *= U[i][i];
//        //      free(L[i]);free(U[i]);
//    }

//    free(L); free(U);
//    //   
//    return tmp;

//}



///*
// * 
// */
//int main(int argc, char** argv)
//{

//    double** A, *b, *x;
//    double** L, **U, **C;
//    unsigned int n = 5;
//    int i, j;

//    A = (double**)calloc(n, sizeof(double*));
//    L = (double**)calloc(n, sizeof(double*));
//    U = (double**)calloc(n, sizeof(double*));
//    C = (double**)calloc(n, sizeof(double*));

//    b = (double*)calloc(n, sizeof(double));
//    x = (double*)calloc(n, sizeof(double));


//    //    
//    for (i = 0; i < n; i++)
//    {
//        A[i] = (double*)calloc(n, sizeof(double));
//        L[i] = (double*)calloc(n, sizeof(double));
//        U[i] = (double*)calloc(n, sizeof(double));
//        C[i] = (double*)calloc(n, sizeof(double));
//    }

//    init(n, A, b);
//    printArr(n, A);
//    printf("\n");
//    gauss(n, A, x, b);
//    printArr(n, A);
//    printf("\n");

//    //   gaussJor(n, A, x, b);      
//    //   printArr(n, A);
//    //   printf("\n"); 
//    //Ax = b
//    //LUx = b => Ly = b | Ux = y

//    // solveLU(n, A, x, b);
//    // printArr(n, A);
//    // printf("\n");    
//    // fprintf(stdout, "\nDeterminant: %lf\n", det(n, A));



//    printf("Solution:\n");
//    for (i = 0; i < n; i++)
//    {
//        printf("x[%d]=%lf\t", i + 1, x[i]);
//        free(A[i]); free(U[i]); free(L[i]);

//    }
//    //    printf("\n"); 
//    //    for(i=0; i < n; i++){
//    //        printf("b[%d]=%lf\t",i+1,b[i]);
//    //        free(A[i]); free(U[i]); free(L[i]);
//    //    }
//    //    printf("\n");

//    free(A); free(x); free(b);
//    free(L); free(U); free(C);


//    return (EXIT_SUCCESS);
//}
