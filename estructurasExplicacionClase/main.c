#include <stdio.h>
#include <stdlib.h>
#include "dataWarehouse.h"
#include "empleado.h"
#include <string.h>

#define TAM 10
#define TAMSEC 5
#define CANTHARDCODE 10

// <>

typedef struct
{
    int dia;
    int mes;
    int anio;

}eFecha;

typedef struct
{
    int id;
    char nombre[20];
    char sexo;
    int edad;
    float sueldo;
    eFecha fechaIngreso;
    int idSector;
    int isEmpty;

}eEmpleado;

typedef struct
{
    int id;
    char descripcion[20];
}eSector;


void mostrarEmpleado(eEmpleado x, eSector sectores[], int tamSec);

void mostrarEmpleados (eEmpleado vec[], int tam, eSector sectores[], int tamSec);

void ordenarEmpleados(eEmpleado vec[], int tam);

void inicializarEmpleados(eEmpleado vec[], int tam);

int menu();

int buscarLibre(eEmpleado vec[], int tam);

int buscarEmpleado (int id, eEmpleado vec[], int tam);

int altaEmpleado(int idx, eEmpleado vec[], int tam);

void bajaEmpleado(eEmpleado vec[], int tam);

void modificarEmpleado(eEmpleado vec[], int tam);

void hardcodearEmpleados(eEmpleado vec[], int cant);

void informar(eEmpleado vec[], int tam);

char menuInformes();

//void informeEmpleadosXAnio(eEmpleado vec[], int tam);

void cargarDescripcionSector(char decripcion[], int id, eSector sectores[], int tam);

int main()
{
    char seguir='s';
    char confirma;
    int proximoId=1000;
    eEmpleado lista [TAM] = {
                            {1234, "Jose", 'm', 23, 12300, {12,3,2018}},
                            {3291, "Juana", 'f', 31, 23400, {10,11,2015}},
                            {4455,"Daniela",'f',34,21800,{16,3,2017}},
                            {1189,"Lucia",'f',20,20500,{12,2,2014}},
                            {1020,"Andres",'m',23,19700,{7,4,2002}}};

    eSector sectores[] = {{1, "sistemas"}, {2, "recursos humanos"}, {3, "ventas"}, {4, "compras"}, {5. "contable"}};
    /*for(int i=0; i<TAM; i++)
    {
        printf("Ingrese id: ");
        scanf("%d", &lista[i].id);

        printf("Ingrese nombre:");
        fflush(stdin);
        gets(lista[i].nombre);

        printf("Ingrese sexo: ");
        fflush(stdin);
        scanf("%c", &lista[i].sexo);

        printf("Ingrese edad: ");
        scanf("%d", &lista[i].edad);

        printf("Ingrese sueldo: ");
        fflush(stdin);
        scanf("%f", &lista[i].sueldo);

        printf("Ingrese fecha ingreso dd/mm/aaaa: ");
        scanf("%d/%d/%d,", &lista[i].fechaIngreso.dia, &lista[i].fechaIngreso.mes, &lista[i].fechaIngreso.anio);
    }*/
    inicializarEmpleados(lista, TAM);

    hardcodearEmpleados(lista, 5);
    proximoId+=5;

    do
    {
        switch(menu())
        {

            case 1:
                if(altaEmpleado(proximoId, lista, TAM))
                {
                    proximoId++;
                }
                break;
            case 2:
                modificarEmpleado(lista, TAM);
                break;
            case 3:
                bajaEmpleado(lista, TAM);
                break;
            case 4:
                printf("ordenar");
                break;
            case 5:
                mostrarEmpleados(lista, TAM, sectores, TAMSEC);
                break;
            case 6:
                informar(lista, TAM);
                break;
            case 7:
                printf("Confirma salida: ");
                fflush(stdin);
                scanf("%c", &confirma);
                if(confirma=='s')
                    seguir='n';
                break;
        }
    }while(seguir=='s');

    //mostrarEmpleados(lista, TAM);
    //ordenarEmpleados(lista, TAM);
    //mostrarEmpleados(lista, TAM);



    return 0;
}



void mostrarEmpleado(eEmpleado x, eSector sectores[], int tamSec)
{
    char nombreSector[20];

    cargarDescripcionSector(nombreSector, x.idSector, sectores, tamSec);

    printf("%d %10s %c %d %.2f %02d/%02d/%4d %10s\n", x.id, x.nombre, x.sexo, x.edad, x.sueldo, x.fechaIngreso.dia, x.fechaIngreso.mes, x.fechaIngreso.anio, nombreSector);
}

void mostrarEmpleados (eEmpleado vec[], int tam, eSector sectores[], int tamSec)
{
    int flag=0;
    system("cls");
    printf("*******Listado de empleados*********\n");
    printf("  Id   Nombre    Sexo    Edad   Sueldo    Fecha ingreso  Sector\n\n");
    for(int i=0; i<tam; i++)
    {
        if(vec[i].isEmpty==0)
        {
            mostrarEmpleado(vec[i], sectores, tamSec);
            flag=1;
        }
    }
    if(flag==0)
    {
        printf("\nNo hay empleados que listar\n");
    }
    system("pause");
}

void ordenarEmpleados(eEmpleado vec[], int tam)
{
    eEmpleado auxEmpleado;
    for(int i=0; i<tam-1;i++)
    {
        for(int j=i+1; j<tam; j++)
        {
            if(vec[i].sexo > vec[j].sexo )
            {
                auxEmpleado=vec[i];
                vec[i]=vec[j];
                vec[j]=auxEmpleado;
            }
            else if (vec[i].sexo == vec[j].sexo && strcmp(vec[i].nombre, vec[j].nombre))
            {
                auxEmpleado=vec[i];
                vec[i]=vec[j];
                vec[j]=auxEmpleado;
            }
        }
    }
}

void inicializarEmpleados(eEmpleado vec[], int tam)
{
    for(int i=0; i<tam;i++)
    {
        vec[i].isEmpty=1;
    }
}

int menu()
{
    int opcion;

    system("cls");

    printf("+++++++Gestion de empleados++++++++\n\n");
    printf("1. Alta empleado\n");
    printf("2. modificar empleado\n");
    printf("3. baja empleado\n");
    printf("4. ordenar empleado\n");
    printf("5. listar empleado\n");
    printf("6. informes empleado\n");
    printf("7. salir\n");
    printf("Ingrese opcion:");
    fflush(stdin);
    scanf("%d", &opcion);

    return opcion;

}

int buscarLibre(eEmpleado vec[], int tam)
{
    int indice=-1;
    for(int i=0;i<tam;i++)
    {
        if(vec[i].isEmpty==1)
        {
            indice=i;
            break;
        }
    }


    return indice;
}

int buscarEmpleado (int id, eEmpleado vec[], int tam)
{
    int indice=-1;
    for(int i=0;i<tam;i++)
    {
        if(vec[i].id==id && vec[i].isEmpty==0)
        {
            indice=i;
            break;
        }
    }


    return indice;
}

int altaEmpleado(int idx, eEmpleado vec[], int tam)
{
    int todoOk=0;
    int indice = buscarLibre(vec, tam);
    //int id;
    int existe;
    eEmpleado auxEmpleado;

    system("cls");

    printf("******Alta empleado*****\n\n");

    if(indice ==-1)//Hay lugar?
    {
        printf("Sistema completo\n\n");
    }
    else
    {
        /*
        //printf("Ingrese id: ");
        //scanf("%d", &id);

        //existe=buscarEmpleado(id, vec, tam);

        if(existe !=-1)//el id ya esta?
        {
            printf("Ya existe un empleado registrado con ese id\n");
        }
        else
        {*/
            auxEmpleado.id=idx;

            printf("Ingrese nombre: ");
            fflush(stdin);
            gets(auxEmpleado.nombre);

            printf("Ingrese sexo: ");
            fflush(stdin);
            scanf("%c", &auxEmpleado.sexo);

            printf("Ingrese edad: ");
            scanf("%d", &auxEmpleado.edad);

            printf("Ingrese sueldo");
            scanf("%f", &auxEmpleado.sueldo);

            printf("Ingrese fecha ingreso: ");
            scanf("%d %d %d", &auxEmpleado.fechaIngreso.dia, &auxEmpleado.fechaIngreso.mes, &auxEmpleado.fechaIngreso.anio);


           // mostrarSectores(sectores, tamSec);
           // printf("Ingrese id del sector: ");
           // scanf("d", &auxEmpleado.idSector);

            auxEmpleado.isEmpty=0;


            vec[indice]=auxEmpleado; // Copio al vector el empleado nuevo

            todoOk=1;
        //} //else interior
    }//else exterior
    return todoOk;
} // fin funcion

void bajaEmpleado(eEmpleado vec[], int tam, eSector sectores[], int tamSec)
{
    int id;
    int indice;
    char confirma;
    system("cls");

    printf("Baja empleado******\n\n");
    printf("INgrese id: ");
    scanf("%d", &id);

    indice=buscarEmpleado(id, vec, tam);

    if(indice == -1)
    {
       printf("No hay registro de un empleado con el id %d\n\n", id);
    }
    else
    {
        mostrarEmpleado(vec[indice], sectores);
        printf("\nConfirma baja?: ");
        fflush(stdin);
        scanf("%c", &confirma);

        if(confirma=='s')
        {
            vec[indice].isEmpty=1;
            printf("Se ha realizado la baja con exito\n\n");
        }
        else
        {
            printf("Se ha cancelado la operacion\n\n");
        }

    }
}

void modificarEmpleado(eEmpleado vec[], int tam)
{
    int id;
    int indice;
    char confirma;
    float nuevoSueldo;

    system("cls");

    printf("modificar empleado******\n\n");
    printf("INgrese id: ");
    scanf("%d", &id);

    indice=buscarEmpleado(id, vec, tam);

    if(indice == -1)
    {
       printf("No hay registro de un empleado con el id %d\n\n", id);
    }
    else
    {
        mostrarEmpleado(vec[indice]);

        printf("\nModifica sueldo?: ");
        fflush(stdin);
        scanf("%c", &confirma);

        if(confirma=='s')
        {
            printf("Ingrse nuevo sueldo: ");
            scanf("%f", &nuevoSueldo);
            vec[indice].sueldo=nuevoSueldo;
            printf("Se ha actualizado el sueldo con exito\n\n");
        }
        else
        {
            printf("Se ha cancelado la operacion\n\n");
        }

    }
}

void hardcodearEmpleados(eEmpleado vec[], int cant)
{
    for(int i=0;i<cant;i++)
    {
        vec[i].id=ids[i];
        strcpy(vec[i].nombre, nombres[i]);
        vec[i].edad=edades[i];
        vec[i].sexo=sexos[i];
      //  vec[i].sueldo=sueldos[i];
        vec[i].fechaIngreso.dia=dias[i];
        vec[i].fechaIngreso.mes=meses[i];
        vec[i].fechaIngreso.anio=anios[i];
        vec[i].idSector=idsSector[i];
        vec[i].isEmpty=0;

    }
}


void informar(eEmpleado vec[], int tam)
{
    char seguir='s';
    char confirma;

    do
    {
        system("cls");
        switch(menuInformes())
        {

            case 'a':
                informarEmpleadosXAnio(vec, tam);
                break;
            case 'b':
                printf("Informe B\n");
                break;
            case 'c':
                printf("Informe C\n");
                break;
            case 'd':
                printf("Informe D\n");
                break;
            case 'e':
                printf("Informe E\n");
                break;
            case 'f':
                printf("Informe F\n");
                break;
            case 'g':
                printf("Confirma salida: ");
                fflush(stdin);
                scanf("%c", &confirma);
                if(confirma=='s')
                    seguir='n';
                break;
        }
        system("pause");
    }while(seguir=='s');
}

char menuInformes()
{
    char opcion;
    system("cls");
    printf("++++Informes empleados+++++\n\n");

    printf("a. Listar empleados de un anio\n");
    printf("b. Informe b\n");
    printf("c. Informe c\n");
    printf("d. Informe d\n");
    printf("e. Informe e\n");
    printf("f. informe f\n");
    printf("g. salir\n");
    printf("Ingrese opcion:");
    fflush(stdin);
    scanf("%c", &opcion);

    return opcion;


}

int cargarDescripcionSector(char descripcion[], int id, eSector sectores[], int tam)
{
    int todoOk=0;

    for(int i=0; i<tam;i++)
    {
        if(sectores[i].id==id)
        {
            strcpy(descripcion, sectores[i].descripcion);
            todoOk=1;
        }
    }


    return todoOk;
}

/*
void informarEmpleadosXAnio(eEmpleado vec[], int tam)
{
    int anio;
    printf("Ingrese anio a buscar: ");
    scanf("%d", &anio);
}

void mostrarSector(eSector sector)
{
    printf("%d %10s \n", sectores[i].id, sectores[i].descripcion);
}

void mostrarSectores (eSector sectores[], int tam)
{
    int flag=0;
    //system("cls");
    printf("******Sectores*********\n");
    printf("  Id   Descripcion \n\n");
    for(int i=0; i<tam; i++)
    {
         printf("%d %10s \n", sectores[i].id, sectores[i].descripcion);
    }
}

void informarEmpleadosSector(eEmpleado empleados[], int tam, eSector sectores[], int tamsec)
{
    int idSector;
    int flag=0;

    system("cls");
    printf("******informe empleado Sectores*********\n");
    mostrar Sectores(sectores, tamsec);
    printf("INgrese id del sector: ");
    scanf("%d", &idSector);
    //
    for(int i=0;i z tam;i++)
    {
        if(empleados[i].isEmpty==0 && empleados[i].idSector==idSector)
        {
            mostrarEmpleado(empleados[i], sectores, tamsec);
            flag=1;
        }
        for(int j=0;j z tam;j++)
        {

        }
    }
}
*/
