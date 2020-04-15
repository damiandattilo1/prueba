#include <stdio.h>
#include <stdlib.h>

int menu ()
{
        int opcion;

        printf("\n\nMENU\n");

        printf("\n1 - Ingrese primer numero: ");
        printf("\n2- Ingrese segundo numero: ");
        printf("\n3- Calcular resultados");
        printf("\n4- Mostrar resultados");
        printf("\n5- Salir\n\n");

        scanf("%d", &opcion);

        return opcion;


}


void calcular (int x, int y, int *s, int *r, int *m, float *d, int *fx, int *fy)
{
    printf("\nCalculando...\n");

    *s=suma(x, y);
    *r=resta(x, y);
    *m=multiplicacion(x, y);
    *d=((float)x/(float)y);

    *fx=factorial(x);
    *fy=factorial(y);
}

int suma (int a, int b)
{
    return (a+b);
}

int resta (int a, int b)
{
    return (a-b);
}

int multiplicacion (int a, int b)
{
    return (a*b);
}

float dividir (float a, float b)
{
    return (a/b);
}

int factorial (int a)
{
    int fact;

    if(a==1)
    {
        fact = 1;
    }
    else
    {
        fact=a*factorial(a-1);
    }

    return fact;
}

void imprimir(int sumar, int restar, int multiplicar, float dividir, int factorialX, int factorialY)
{
        printf("\nLa suma es: %d", sumar);
        printf("\nLa restar es: %d", restar);
        printf("\nLa multiplicacion es: %d", multiplicar);
        printf("\nLa division es: %.2f", dividir);

        printf("\nEl factorial del primer valor es: %d", factorialX);
        printf("\nEl factorial del segundo valor es: %d", factorialY);
}
