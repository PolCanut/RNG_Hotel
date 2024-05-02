using RNG.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RNG.Controllers
{
    public class EmpleadoController
    {
        private readonly ApplicationDbContext _dbContext;

        public EmpleadoController()
        {
            _dbContext = new ApplicationDbContext(); // Crea una instancia del DbContext
        }

        // Método para registrar un nuevo empleado
        public void RegistrarEmpleado(Empleado empleado)
        {
            if (empleado != null)
            {
                _dbContext.Empleados.Add(empleado);
                _dbContext.SaveChanges();
                MessageBox.Show("Empleado registrado correctamente.");
            }
            else
            {
                MessageBox.Show("Error al registrar el empleado. Por favor, revise los datos ingresados.");
            }
        }

        // Método para consultar la lista de empleados
        public IQueryable<Empleado> ConsultarEmpleados()
        {
            return _dbContext.Empleados;
        }

        // Método para buscar un empleado por su ID
        public Empleado BuscarEmpleadoPorId(int idEmpleado)
        {
            return _dbContext.Empleados.FirstOrDefault(e => e.idEmpleado == idEmpleado);
        }

        // Método para actualizar los datos de un empleado
        public void ActualizarEmpleado(Empleado empleado)
        {
            if (empleado != null)
            {
                _dbContext.Entry(empleado).State = System.Data.Entity.EntityState.Modified;
                _dbContext.SaveChanges();
                MessageBox.Show("Empleado actualizado correctamente.");
            }
            else
            {
                MessageBox.Show("Error al actualizar el empleado. Por favor, revise los datos ingresados.");
            }
        }

        // Método para eliminar un empleado
        public void EliminarEmpleado(int idEmpleado)
        {
            var empleado = _dbContext.Empleados.FirstOrDefault(e => e.idEmpleado == idEmpleado);
            if (empleado != null)
            {
                _dbContext.Empleados.Remove(empleado);
                _dbContext.SaveChanges();
                MessageBox.Show("Empleado eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("Error al eliminar el empleado. Empleado no encontrado.");
            }
        }
    }
}