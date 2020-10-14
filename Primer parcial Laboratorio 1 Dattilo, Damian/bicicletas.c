#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>
#include "dataStore.h"
#include <string.h>
#include "bicicletas.h"

int inicializarBicis(eBici bicis[], int tam)
{
    int error=1;

    if(bicis != NULL && tam > 0)
    {
        for(int i=0; i<tam; i++)
        {
            bicis[i].isEmpty=1;
        }
        error= 0;
    }
    return error;
}

int altaBici(eBici bicis[], int tam, int id)
{
    int error=1;
    eBici nuevaBici;//auxiliar para cargar una nueva persona
    int indice;

    if(bicis != NULL && tam > 0 && id>0)
    {
        indice = buscarLibre(bicis, tam);
        if(indice==-1)
        {
            printf("No hay lugar, sistema completo\n");
        }
        else
        {
            nuevaBici.id = id;


            printf("Ingrese marca: ");
            fflush(stdin);
            gets(nuevaBici.marca);

            printf("Ingrese id tipo: ");
            scanf("%d", &nuevaBici.idTipo);

            printf("Ingrese idColor: ");
            scanf("%d", &nuevaBici.idColor);

            printf("Ingrese rodado: ");
            scanf("%f", &nuevaBici.rodado);

            nuevaBici.isEmpty=0;

            bicis[indice]=nuevaBici;//Se pasan todos los datos guardados en el auxiliar hacia el vector

            error =0;
        }


    }

    return error;
}

int modificarBici(eBici bicis[], int tam)
{
    int error=1;
    int indice;
    int id;
    char confirmar;
    char modificar;

    if(bicis !=NULL && tam >0)//validacion de datos de entrada
    {
        system("cls");
        printf("Modificar Bici\n\n");
        mostrarBicis(bicis, tam);//Funcion MostrarPersonas para ver los numeros de legajo
        printf("Ingrese id: ");
        scanf("%d", &id);

        indice = buscarBici(bicis, tam, id);//la variable indice toma el valor retornado por la funcion buscarPersona

        if(indice==-1)
        {
            printf("No se encontro el id\n\n");
        }
        else
        {
            printf("\nA Tipo\n");
            printf("b Rodado\n\n");

            printf("Que desea modificiar?: ");
            fflush(stdin);
            scanf("%c", &modificar);
            modificar=tolower(modificar);
            switch(modificar)
            {
            case 'a':
                printf("Ingrese nuevo id tipo: ");
                fflush(stdin);
                scanf("%d", &bicis[indice].idTipo);
                break;

            case 'b':
                printf("Ingrese nuevo rodado: ");
                scanf("%f", &bicis[indice].rodado);
                break;
            }
            printf("Desea confirmar el cambio?(s=Si o n=No): ");
            fflush(stdin);
            scanf("%c", &confirmar);
            confirmar=tolower(confirmar);
            if(confirmar=='s')
            {
                error=0;
            }
            else
            {
                error=1;
            }
        }
    }
    return error;
}

int bajaBici(eBici bicis[], int tam)
{
    int error=1;
    int indice;
    int id;
    char confirma;

    if(bicis !=NULL && tam >0)
    {
        system("cls");
        printf("Baja de bicicletas\n\n");
        mostrarBicis(bicis, tam);//Funcion MostrarPersonas para ver los numeros de legajo
        printf("Ingrese Id: ");
        scanf("%d", &id);

        indice = buscarBici(bicis, tam, id);//la variable indice toma el valor retornado por la funcion buscarPersona

        if(indice==-1)//Si no hay nada cargado se le da el valor -1
        {
            printf("No hay ninguna bici con ese legajo\n\n");
        }
        else
        {
            mostrarBici(bicis[indice]);
            printf("Confirma eliminar esta bici?: ");
            fflush(stdin);
            scanf("%c", &confirma);
            if(confirma=='s')
            {
                bicis[indice].isEmpty=1;//Se vacia isEmpty en el indice indicado dentro del vector
                error=0;
            }
            else
            {
                error=2;//si el usuario cancela la baja devuelve un 2
            }
        }
    }
    return error;
}


int mostrarBicis(eBici bicis[], int tam)
{
    int error=1;//comienza con un error hasta que la funcion dia lo contrario
    int flag=0;

    if(bicis!= NULL && tam > 0)//verifica que el primer dato sea un vector y el segundo el tamaño mayor a 0
    {
        printf("   Id       Marca   Tipo     Color   Rodado   \n");
        printf(" ----------------------------------------------\n");
        for(int i=0; i<tam; i++)
        {
            if(bicis[i].isEmpty==0)// Si isEmpty dentro del vector es 0 entonces muestra la funcion mostrar bici
            {
                mostrarBici(bicis[i]);
                flag=1;//Si encuentra datos cargados en la lista el valor de la flag es 1
            }
        }
        printf("\n\n");
        if(flag==0)//Si no encuentra datos cargados en la lista el valor de la flag es 0
        {
            printf("    No hay bicis en la lista\n\n");
        }
        error= 0;//Una vez verificado que sea un vector de tamaño mayor a 0 devuelvo 0 errores
    }

    return error;
}


void mostrarBici(eBici unaBici)
{
    printf(" %4d   %12s   %d    %d   %.2f\n", unaBici.id, unaBici.marca, unaBici.idTipo, unaBici.idColor, unaBici.rodado);//Imprime los datos de la bici segun su posicion en el vector
}

int buscarLibre(eBici bicis[], int tam)
{
    int indice=-1;//Dentro del tamaño de la funcion el indice puede ser 0 o mayor
    for(int i=0; i<tam; i++)
    {
        if(bicis[i].isEmpty==1)//Cuando el valor de i sea ==1(lugar vacio) indice va a valer la direccion vacia del vector
        {
            indice=i;
            break;
        }
    }
    return indice;//retorna el valor del indice vacio en el vector
}

int buscarBici(eBici bicis[], int tam, int id)
{

    int indice;

    for(int i=0; i<tam; i++)
    {
        if(bicis[i].id==id && bicis[i].isEmpty==0)//se revisa los legajos del vector ingresado hasta encontrar el que es igual al numero de legajo ingresado y que el indice este cargado"0"
        {
            indice=i;//Se le da el valor a indice donde esta cargado el numero de legajo que buscamos
            break;
        }
        else
        {
            indice= -1;
        }
    }
    return indice;
}

int mostrarColores(eColor array[],int tam)
{
    int retorno=-1;

    if(array != NULL && tam > 0)
    {
        retorno=0;
       printf("\n***LISTA DE COLORES***\n");
        printf("ID    DESCRIPCION\n");
        printf("---------------------------\n");
        for(int i=0;i<tam;i++)
        {
            mostrarColor(array[i]);
        }

    }


    return retorno ;

}
void mostrarColor(eColor unColor)
{

    printf("%d   %s\n", unColor.id,unColor.nombreColor);

}

int mostrarTipos(eTipo array[],int tam)
{
    int retorno=-1;

    if(array != NULL && tam > 0)
    {
       printf("\n***LISTA DE TIPOS***\n");
        printf("ID    DESCRIPCION\n");
        printf("---------------------------\n");
        for(int i=0;i<tam;i++)
        {
            mostrarTipo(array[i]);
        }

    }


    return retorno ;

}
void mostrarTipo(eTipo unTipo)
{

    printf("%d   %s\n", unTipo.id,unTipo.descripcion);

}

int mostrarServicios(eServicio array[],int tam)
{
    int retorno=-1;

    if(array != NULL && tam > 0)
    {
       printf("\n***LISTA DE SERVICIOS***\n");
        printf("ID    DESCRIPCION    PRECIO\n");
        printf("---------------------------\n");
        for(int i=0;i<tam;i++)
        {
            mostrarServicio(array[i]);
        }

    }


    return retorno ;

}
void mostrarServicio(eServicio unServicio)
{

    printf("%d   %s      %d\n", unServicio.id, unServicio.descripcion, unServicio.precio);

}

int hardcodearBicis(eBici bicis[], int tam, int cant)
{
    int id = 1000;
    int retorno = -1;
    if(bicis != NULL && tam > 0 && cant <=tam)
    {
        retorno=0;
        for(int i =0; i< cant; i++)
        {
            bicis[i].id = id;
            strcpy(bicis[i].marca, marcaBici[i]);
            bicis[i].idTipo = idTipoBici[i];
            bicis[i].idColor = idColorBici[i];
            bicis[i].rodado= rodadoBici[i];
            bicis[i].isEmpty=0;
            retorno++;
            id++;
        }
    }
    return retorno;
}
