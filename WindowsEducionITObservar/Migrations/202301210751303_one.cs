namespace WindowsEducionITObservar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class one : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carreras",
                c => new
                    {
                        CarreraId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.CarreraId);
            
            CreateTable(
                "dbo.Cursoes",
                c => new
                    {
                        CursoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.CursoId);
            
            CreateTable(
                "dbo.Detalles",
                c => new
                    {
                        DetalleId = c.Int(nullable: false, identity: true),
                        PlanillaId = c.Int(nullable: false),
                        EstadoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DetalleId);
            
            CreateTable(
                "dbo.Estadoes",
                c => new
                    {
                        EstadoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.EstadoId);
            
            CreateTable(
                "dbo.Estudiantes",
                c => new
                    {
                        EstudianteId = c.Int(nullable: false, identity: true),
                        LocalidadId = c.Int(nullable: false),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Telefono = c.String(),
                        Calle = c.String(),
                        Numero = c.String(),
                    })
                .PrimaryKey(t => t.EstudianteId);
            
            CreateTable(
                "dbo.Evaluacions",
                c => new
                    {
                        EvaluacionId = c.Int(nullable: false, identity: true),
                        TipoId = c.Int(nullable: false),
                        EstudianteId = c.Int(nullable: false),
                        DetalleId = c.Int(nullable: false),
                        Nota = c.String(),
                    })
                .PrimaryKey(t => t.EvaluacionId);
            
            CreateTable(
                "dbo.Localidads",
                c => new
                    {
                        LocalidadId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.LocalidadId);
            
            CreateTable(
                "dbo.Materias",
                c => new
                    {
                        MateriaId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.MateriaId);
            
            CreateTable(
                "dbo.Plans",
                c => new
                    {
                        PlanId = c.Int(nullable: false, identity: true),
                        CarreraId = c.Int(nullable: false),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.PlanId);
            
            CreateTable(
                "dbo.Planillas",
                c => new
                    {
                        PlanillaId = c.Int(nullable: false, identity: true),
                        CarreraId = c.Int(nullable: false),
                        MateriaId = c.Int(nullable: false),
                        ProfesorId = c.Int(nullable: false),
                        CursoId = c.Int(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PlanillaId);
            
            CreateTable(
                "dbo.Profesors",
                c => new
                    {
                        ProfesorId = c.Int(nullable: false, identity: true),
                        LocalidadId = c.Int(nullable: false),
                        Nombre = c.String(),
                        Apellido = c.String(),
                    })
                .PrimaryKey(t => t.ProfesorId);
            
            CreateTable(
                "dbo.Tipoes",
                c => new
                    {
                        TipoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.TipoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tipoes");
            DropTable("dbo.Profesors");
            DropTable("dbo.Planillas");
            DropTable("dbo.Plans");
            DropTable("dbo.Materias");
            DropTable("dbo.Localidads");
            DropTable("dbo.Evaluacions");
            DropTable("dbo.Estudiantes");
            DropTable("dbo.Estadoes");
            DropTable("dbo.Detalles");
            DropTable("dbo.Cursoes");
            DropTable("dbo.Carreras");
        }
    }
}
