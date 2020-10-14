#ifndef TRABAJOS_H_INCLUDED
#define TRABAJOS_H_INCLUDED

typedef struct
{
    int dia;
	int mes;
	int anio;
}eFecha;

typedef struct
{
	int id;
	int idBici;
	int idServicio;
	eFecha fecha;
	int isEmpty;
}eTrabajo;


#endif // TRABAJOS_H_INCLUDED


int inicializarTrabajos(eTrabajo trabajos[], int tam);
int altaTrabajo(eTrabajo trabajos[], int tamTrab, int idTrab);
int buscarTrabajoLibre(eTrabajo trabajos[], int tam);
int mostrarTrabajos(eTrabajo trabajos[], int tam);
void mostrarTrabajo(eTrabajo unTrabajo);
