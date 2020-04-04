#include <stdio.h>
#include <stdlib.h>

int main()
{
    int num1, num2, resultado;

    num1=30;
    num2=20;

    printf("Ingrese numero: ");
    scanf("%d", &num1);

    printf("Ingrese otro numero: ");
    scanf("%d", &num2);

    resultado=num1+num2;

    printf("\nEl resultado es: %d", resultado);

    return 0;
}
