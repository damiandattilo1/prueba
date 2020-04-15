#include <stdio.h>
#include <stdlib.h>
#include "UTN.h"
#include "alumnoD.h"
// Trabajo práctico N1 2020   AL 15 04 20
// MEJOR VERSION


int main()
{
    // Desde la función main, se llama a la función menu, desde la cual se derivan las respectivas operaciones
    int opcion;
//    int respuesta;
    int x;
    int y;

    int sumar;
    int restar;
    int multiplicar;
    float dividir;
    int ingreso1 =0;
    int ingreso2 =0;
    int calculo =0;

    int factorialX;
    int factorialY;


        do
        {
            fflush(stdin);
            opcion=menu();
            fflush(stdin);
            system("cls");
            switch(opcion)
            {
            case 1:
                /*respuesta=*/utn_getNumero(&x, "\nIngrese primer operando: ", "ERROR: No es una opcion valida\n", -100, 100,3);
                ingreso1=1;
                break;
            case 2:
                /*respuesta=*/utn_getNumero(&y, "\nIngrese segundo operando: ", "ERROR: No es una opcion valida\n", -100, 100,3);
                ingreso2=1;
                break;
            case 3:
            {
                if(!ingreso1 || !ingreso2)
                {
                    printf("ERROR, debe ingresar los dos valores");
                }
                else
                {
                    calcular(x, y, &sumar, &restar, &multiplicar, &dividir, &factorialX, &factorialY);
                    calculo=1;
                }
                break;
            }
            case 4:
            {
                if(!ingreso1 || !ingreso2 || !calculo)
                {
                    printf("ERROR Debe ingresar y calcular");
                }
                else
                {
                    imprimir(sumar, restar, multiplicar, dividir, factorialX, factorialY);
                }
                break;
            }
            case 5:
                break;
            default:
                printf("\nNo es una opcion valida");
            }
        }while(opcion!=5);
    return 0;
}



/*
void suma (int a, int b)
{
    int res;
    res= (a+b);
    imprimir(a, '+', b, (float)res);
}

void resta (int a, int b)
{
    int res;
    res= (a-b);
    imprimir(a, '-', b, (float)res);
}

void mul (int a, int b)
{
    int res;
    res= (a*b);
    imprimir(a, '*', b, (float)res);
}

void division (int a, int b)
{
    float res;
    if(b==0)
    {
        printf("\nERROR: No es posible dividir por cero\n");
    }
    else
    {
        res= ((float)a/(float)b);
        imprimir(a, '/', b, res);
    }
}
*/
