import java.sql.*;
import java.util.Scanner;


public class Main {
    public static void main(String[] args) throws ClassNotFoundException {

        try {
            //obtenemos la conexión a la base de datos
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            String connectionUrl = "jdbc:sqlserver://localhost:1433;databaseName=JDBC;user=sa;password=montecastelo;TrustServerCertificate=True;";
            Connection conexion = DriverManager.getConnection(connectionUrl);
            System.out.println("Conexión exitosa a la base de datos JDBC");
            System.out.println("-----------------------------------------");

            //****************************************************
            //Ejercicio 1
            //****************************************************

            //creamos un objeto Statement para poder ejecutar sentencias SQL
            Statement stmt = conexion.createStatement();

            //escribimos la sentencia SQL para obtener todas las oficinas de Galicia
            ResultSet resultado1 = stmt.executeQuery("SELECT ciudad FROM oficinas WHERE region LIKE 'Galicia'");

            //añadimos una linea para especificar que mostraremos a continuacion son las oficinas de Galicia
            System.out.println("Oficinas en Galicia:");

            //recorremos el resultado y lo mostramos por pantalla

            while (resultado1.next()) {
                System.out.println(resultado1.getString("ciudad"));
            }

            System.out.println("-----------------------------------------");

            //****************************************************
            //Ejercicio 2
            //Permita insertar registros en la tabla EMP utilizando consultas parametrizadas
            //****************************************************

            //creamos la clase PreparedStatement para poder ejecutar sentencias SQL parametrizadas
            Statement stmt2 = conexion.prepareStatement("INSERT INTO EMP (EMPNO, ENAME, JOB, MGR, HIREDATE, SAL, COMM, DEPTNO) VALUES (?, ?, ?, ?, ?, ?, ?, ?)");

            //pedimos por consola los datos del empleado para meterlo en la base de datos
            Scanner lectura = new Scanner(System.in);
            System.out.println("Introduce el número del empleado: ");
            int empno = lectura.nextInt();
            System.out.println("Introduce el nombre del empleado: ");
            String ename = lectura.next();
            System.out.println("Introduce el trabajo del empleado: ");
            String job = lectura.next();
            System.out.println("Introduce el número del manager: ");
            int mgr = lectura.nextInt();
            System.out.println("Introduce la fecha de contratación: ");
            String hiredate = lectura.next();
            System.out.println("Introduce el salario: ");
            int sal = lectura.nextInt();
            System.out.println("Introduce la comisión: ");
            int comm = lectura.nextInt();
            System.out.println("Introduce el número del departamento: ");
            int deptno = lectura.nextInt();

            //añadimos los datos a la sentencia SQL
            ((PreparedStatement) stmt2).setInt(1, empno);
            ((PreparedStatement) stmt2).setString(2, ename);
            ((PreparedStatement) stmt2).setString(3, job);
            ((PreparedStatement) stmt2).setInt(4, mgr);
            ((PreparedStatement) stmt2).setString(5, hiredate);
            ((PreparedStatement) stmt2).setInt(6, sal);
            ((PreparedStatement) stmt2).setInt(7, comm);
            ((PreparedStatement) stmt2).setInt(8, deptno);

            //ejecutamos la sentencia SQL
            int registrosInsert = ((PreparedStatement) stmt2).executeUpdate();
            if (registrosInsert > 0) {
                System.out.println("El empleado " + ename + " ha sido introducido en la base de datos JBDC");
            }

            System.out.println("-----------------------------------------");

            //****************************************************
            //Ejercicio 3
            //Permita reducir un 10% el importe de todos los pedidos
            //****************************************************

            // creamos un objeto Statement para poder ejecutar sentencias SQL
            String updatePrecio = "UPDATE PEDIDOS SET IMPORTE = IMPORTE * 0.9";
            int registros = stmt.executeUpdate(updatePrecio);
            if (registros > 0) {
                System.out.println("El importe de todos los pedidos ha sido reducido un 10%");
            }

            System.out.println("-----------------------------------------");

            //****************************************************
            //Ejercicio 4
            //Actualiza en 5 unidades a mayores las cantidades de todos los pedidos cuyo importe
            //sea menor a 3€
            //****************************************************

            // creamos un objeto Statement para poder ejecutar sentencias SQL
            String updateCantidad = "UPDATE PEDIDOS SET CANTIDAD = CANTIDAD + 5 WHERE IMPORTE < 3";
            int registros2 = stmt.executeUpdate(updateCantidad);
            if (registros2 > 0) {
                System.out.println("Las cantidades de todos los pedidos cuyo importe sea menor a 3€ han sido aumentadas en 5 unidades");
            }

            System.out.println("-----------------------------------------");

            //****************************************************
            //Ejercicio 5
            //Utilizando una transacción, aplica las consultas:
            //Insertar un registro en la tabla BONUS (0,25 puntos)
            //Borra todos aquellos empleados mayores de 40 años (0,25 puntos)
            //Permita borrar todos los registros de la tabla SALGRADE (0,25 puntos)
            //Muestra las localizaciones de todos los departamentos
            //****************************************************

            //creamos un try catch para poder hacer rollback en caso de error
            try {
                //creamos un objeto Statement para poder ejecutar sentencias SQL
                conexion.setAutoCommit(false);
                Statement stmt3 = conexion.createStatement();

                //Insertar un registro en la tabla BONUS
                String insertBonus = "INSERT INTO BONUS (ENAME, JOB, SAL) VALUES ('Juan', 'Analista', 2000)";
                int registros3 = stmt3.executeUpdate(insertBonus);
                if (registros3 > 0) {
                    System.out.println("El empleado Juan ha sido introducido en la tabla BONUS");
                }

                //Borra todos aquellos empleados mayores de 40 años
                String deleteEmpleados = "DELETE FROM EMP WHERE HIREDATE < '1981-01-01'";
                int registros4 = stmt3.executeUpdate(deleteEmpleados);
                if (registros4 > 0) {
                    System.out.println("Los empleados mayores de 40 años han sido eliminados de la tabla EMP");
                }

                //Permita borrar todos los registros de la tabla SALGRADE
                String deleteSalgrade = "DELETE FROM SALGRADE";
                int registros5 = stmt3.executeUpdate(deleteSalgrade);
                if (registros5 > 0) {
                    System.out.println("Todos los registros de la tabla SALGRADE han sido eliminados");
                }

                //Muestra las localizaciones de todos los departamentos
                ResultSet resultado2 = stmt3.executeQuery("SELECT LOC FROM DEPT");
                System.out.println("Localizaciones de los departamentos:");
                while (resultado2.next()) {
                    System.out.println(resultado2.getString("LOC"));
                }

                conexion.commit();
            } catch (Exception e) {
                conexion.rollback();
                e.printStackTrace();
            }


        } catch (Exception e) {
            e.printStackTrace();
        }


    }
}