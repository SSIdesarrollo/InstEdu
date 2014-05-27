SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

CREATE SCHEMA IF NOT EXISTS `Proyecto` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci ;
USE `Proyecto` ;

-- -----------------------------------------------------
-- Table `Proyecto`.`Rama`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Proyecto`.`Rama` (
  `Cod_rama` INT NOT NULL AUTO_INCREMENT ,
  `Nombre_rama` VARCHAR(45) NULL ,
  PRIMARY KEY (`Cod_rama`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Proyecto`.`Alumnos`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Proyecto`.`Alumnos` (
  `idAlumnos` INT NOT NULL AUTO_INCREMENT ,
  `Nombre_alumnos` VARCHAR(45) NULL ,
  `Apellido_alumnos` VARCHAR(45) NULL ,
  `Fechandia` VARCHAR(45) NULL ,
  `Fechanmes` VARCHAR(45) NULL ,
  `Fechanano` VARCHAR(45) NULL ,
  `Telefonocel_alumno` VARCHAR(45) NULL ,
  `Direccion_alumno` VARCHAR(45) NULL ,
  `Rama` VARCHAR(45) NULL ,
  `Ciclo` VARCHAR(45) NULL ,
  `Jornada` VARCHAR(45) NULL ,
  `Codigo_final` VARCHAR(45) NULL ,
  `Telefonocasa_alumno` VARCHAR(45) NULL ,
  `Correo_alumno` VARCHAR(45) NULL ,
  `Ce1nombre` VARCHAR(45) NULL ,
  `Ce1telefono` VARCHAR(45) NULL ,
  `Ce2nombre` VARCHAR(45) NULL ,
  `Ce2telefono` VARCHAR(45) NULL ,
  `Ce3nombre` VARCHAR(45) NULL ,
  `Rama_Cod_rama` INT NOT NULL ,
  PRIMARY KEY (`idAlumnos`) ,
  INDEX `fk_Alumnos_Rama1` (`Rama_Cod_rama` ASC) ,
  CONSTRAINT `fk_Alumnos_Rama1`
    FOREIGN KEY (`Rama_Cod_rama` )
    REFERENCES `Proyecto`.`Rama` (`Cod_rama` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Proyecto`.`Tipo_personal`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Proyecto`.`Tipo_personal` (
  `Tipo_personal` INT NOT NULL AUTO_INCREMENT ,
  `Descripcion` VARCHAR(45) NULL ,
  PRIMARY KEY (`Tipo_personal`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Proyecto`.`Tipo_pago`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Proyecto`.`Tipo_pago` (
  `id_tipopago` INT NOT NULL AUTO_INCREMENT ,
  `Descripcion` VARCHAR(45) NULL ,
  `Monto` VARCHAR(45) NULL ,
  PRIMARY KEY (`id_tipopago`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Proyecto`.`Alumno_estado`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Proyecto`.`Alumno_estado` (
  `id_estado` INT NOT NULL ,
  `estado` VARCHAR(45) NULL ,
  `Alumnos_idAlumnos` INT NOT NULL ,
  PRIMARY KEY (`id_estado`) ,
  INDEX `fk_Alumno_estado_Alumnos1` (`Alumnos_idAlumnos` ASC) ,
  CONSTRAINT `fk_Alumno_estado_Alumnos1`
    FOREIGN KEY (`Alumnos_idAlumnos` )
    REFERENCES `Proyecto`.`Alumnos` (`idAlumnos` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Proyecto`.`Personal`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Proyecto`.`Personal` (
  `idPersonal` INT NOT NULL AUTO_INCREMENT ,
  `Nombre_personal` VARCHAR(45) NULL ,
  `Apellido_personal` VARCHAR(45) NULL ,
  `Fechandia` VARCHAR(45) NULL ,
  `Fechanmes` VARCHAR(45) NULL ,
  `Fechanano` VARCHAR(45) NULL ,
  `Telefonocel_personal` VARCHAR(45) NULL ,
  `Direccion_personal` VARCHAR(45) NULL ,
  `Telefonocasa_personal` VARCHAR(45) NULL ,
  `Correo_personal` VARCHAR(45) NULL ,
  `Ce1nombre` VARCHAR(45) NULL ,
  `Ce1telefono` VARCHAR(45) NULL ,
  `Ce2nombre` VARCHAR(45) NULL ,
  `Ce2telefono` VARCHAR(45) NULL ,
  `Ce3nombre` VARCHAR(45) NULL ,
  `Tipo_personal_Tipo_personal` INT NOT NULL ,
  PRIMARY KEY (`idPersonal`) ,
  INDEX `fk_Personal_Tipo_personal1` (`Tipo_personal_Tipo_personal` ASC) ,
  CONSTRAINT `fk_Personal_Tipo_personal1`
    FOREIGN KEY (`Tipo_personal_Tipo_personal` )
    REFERENCES `Proyecto`.`Tipo_personal` (`Tipo_personal` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Proyecto`.`Personal_estado`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Proyecto`.`Personal_estado` (
  `idEstado` INT NOT NULL ,
  `Estado` VARCHAR(45) NULL ,
  `Personal_idPersonal` INT NOT NULL ,
  PRIMARY KEY (`idEstado`) ,
  INDEX `fk_Personal_estado_Personal1` (`Personal_idPersonal` ASC) ,
  CONSTRAINT `fk_Personal_estado_Personal1`
    FOREIGN KEY (`Personal_idPersonal` )
    REFERENCES `Proyecto`.`Personal` (`idPersonal` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Proyecto`.`Pago`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Proyecto`.`Pago` (
  `Cod_pago` INT NOT NULL AUTO_INCREMENT ,
  `Tipo_pago_id_tipopago` INT NOT NULL ,
  `Alumno_estado_id_estado` INT NOT NULL ,
  `Personal_estado_idEstado` INT NOT NULL ,
  PRIMARY KEY (`Cod_pago`) ,
  INDEX `fk_Pago_Tipo_pago` (`Tipo_pago_id_tipopago` ASC) ,
  INDEX `fk_Pago_Alumno_estado1` (`Alumno_estado_id_estado` ASC) ,
  INDEX `fk_Pago_Personal_estado1` (`Personal_estado_idEstado` ASC) ,
  CONSTRAINT `fk_Pago_Tipo_pago`
    FOREIGN KEY (`Tipo_pago_id_tipopago` )
    REFERENCES `Proyecto`.`Tipo_pago` (`id_tipopago` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Pago_Alumno_estado1`
    FOREIGN KEY (`Alumno_estado_id_estado` )
    REFERENCES `Proyecto`.`Alumno_estado` (`id_estado` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Pago_Personal_estado1`
    FOREIGN KEY (`Personal_estado_idEstado` )
    REFERENCES `Proyecto`.`Personal_estado` (`idEstado` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Proyecto`.`Catalogo_alumno`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Proyecto`.`Catalogo_alumno` (
  `Cod_catalogo` INT NOT NULL ,
  `Alumnos_idAlumnos` INT NOT NULL ,
  PRIMARY KEY (`Cod_catalogo`) ,
  INDEX `fk_Catalogo_alumno_Alumnos1` (`Alumnos_idAlumnos` ASC) ,
  CONSTRAINT `fk_Catalogo_alumno_Alumnos1`
    FOREIGN KEY (`Alumnos_idAlumnos` )
    REFERENCES `Proyecto`.`Alumnos` (`idAlumnos` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Proyecto`.`ReporteCobranza`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Proyecto`.`ReporteCobranza` (
  `Cod_reporte` INT NOT NULL ,
  `Alumnos_idAlumnos` INT NOT NULL ,
  PRIMARY KEY (`Cod_reporte`) ,
  INDEX `fk_ReporteCobranza_Alumnos1` (`Alumnos_idAlumnos` ASC) ,
  CONSTRAINT `fk_ReporteCobranza_Alumnos1`
    FOREIGN KEY (`Alumnos_idAlumnos` )
    REFERENCES `Proyecto`.`Alumnos` (`idAlumnos` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Proyecto`.`Curso`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Proyecto`.`Curso` (
  `Cod_curso` INT NOT NULL AUTO_INCREMENT ,
  `Nombre_curso` VARCHAR(45) NULL ,
  PRIMARY KEY (`Cod_curso`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Proyecto`.`Ciclo`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Proyecto`.`Ciclo` (
  `idCiclo` INT NOT NULL AUTO_INCREMENT ,
  `Nombre_ciclo` VARCHAR(45) NULL ,
  PRIMARY KEY (`idCiclo`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Proyecto`.`Pensum`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Proyecto`.`Pensum` (
  `idPensum` INT NOT NULL AUTO_INCREMENT ,
  `Descripcion` VARCHAR(45) NULL ,
  `ano` VARCHAR(45) NULL ,
  PRIMARY KEY (`idPensum`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Proyecto`.`Detallepensum`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Proyecto`.`Detallepensum` (
  `idDetallepensum` INT NOT NULL AUTO_INCREMENT ,
  `Prama` VARCHAR(45) NULL ,
  `Pciclo` VARCHAR(45) NULL ,
  `Pcurso` VARCHAR(45) NULL ,
  `Creditos` VARCHAR(45) NULL ,
  `Pensum_idPensum` INT NOT NULL ,
  `Rama_Cod_rama` INT NOT NULL ,
  `Ciclo_idCiclo` INT NOT NULL ,
  `Curso_Cod_curso` INT NOT NULL ,
  PRIMARY KEY (`idDetallepensum`) ,
  INDEX `fk_Detallepensum_Pensum1` (`Pensum_idPensum` ASC) ,
  INDEX `fk_Detallepensum_Rama1` (`Rama_Cod_rama` ASC) ,
  INDEX `fk_Detallepensum_Ciclo1` (`Ciclo_idCiclo` ASC) ,
  INDEX `fk_Detallepensum_Curso1` (`Curso_Cod_curso` ASC) ,
  CONSTRAINT `fk_Detallepensum_Pensum1`
    FOREIGN KEY (`Pensum_idPensum` )
    REFERENCES `Proyecto`.`Pensum` (`idPensum` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Detallepensum_Rama1`
    FOREIGN KEY (`Rama_Cod_rama` )
    REFERENCES `Proyecto`.`Rama` (`Cod_rama` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Detallepensum_Ciclo1`
    FOREIGN KEY (`Ciclo_idCiclo` )
    REFERENCES `Proyecto`.`Ciclo` (`idCiclo` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Detallepensum_Curso1`
    FOREIGN KEY (`Curso_Cod_curso` )
    REFERENCES `Proyecto`.`Curso` (`Cod_curso` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Proyecto`.`Asigcurso`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Proyecto`.`Asigcurso` (
  `idAsigcurso` INT NOT NULL ,
  `ano` VARCHAR(45) NULL ,
  `Alumnos_idAlumnos` INT NOT NULL ,
  PRIMARY KEY (`idAsigcurso`) ,
  INDEX `fk_Asigcurso_Alumnos1` (`Alumnos_idAlumnos` ASC) ,
  CONSTRAINT `fk_Asigcurso_Alumnos1`
    FOREIGN KEY (`Alumnos_idAlumnos` )
    REFERENCES `Proyecto`.`Alumnos` (`idAlumnos` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Proyecto`.`Detalleasigcurso`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Proyecto`.`Detalleasigcurso` (
  `Notafinal` VARCHAR(45) NULL ,
  `Rama_Cod_rama` INT NOT NULL ,
  `Curso_Cod_curso` INT NOT NULL ,
  `Ciclo_idCiclo` INT NOT NULL ,
  `Asigcurso_idAsigcurso` INT NOT NULL ,
  INDEX `fk_Asignacioncursos_Rama1` (`Rama_Cod_rama` ASC) ,
  INDEX `fk_Asignacioncursos_Curso1` (`Curso_Cod_curso` ASC) ,
  INDEX `fk_Asignacioncursos_Ciclo1` (`Ciclo_idCiclo` ASC) ,
  INDEX `fk_Detalleasigcurso_Asigcurso1` (`Asigcurso_idAsigcurso` ASC) ,
  CONSTRAINT `fk_Asignacioncursos_Rama1`
    FOREIGN KEY (`Rama_Cod_rama` )
    REFERENCES `Proyecto`.`Rama` (`Cod_rama` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Asignacioncursos_Curso1`
    FOREIGN KEY (`Curso_Cod_curso` )
    REFERENCES `Proyecto`.`Curso` (`Cod_curso` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Asignacioncursos_Ciclo1`
    FOREIGN KEY (`Ciclo_idCiclo` )
    REFERENCES `Proyecto`.`Ciclo` (`idCiclo` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Detalleasigcurso_Asigcurso1`
    FOREIGN KEY (`Asigcurso_idAsigcurso` )
    REFERENCES `Proyecto`.`Asigcurso` (`idAsigcurso` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Proyecto`.`Planhr`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Proyecto`.`Planhr` (
  `idPlanhr` INT NOT NULL ,
  `ano` VARCHAR(45) NULL ,
  PRIMARY KEY (`idPlanhr`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Proyecto`.`Asigcatedratico`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Proyecto`.`Asigcatedratico` (
  `idAsigcat` INT NOT NULL AUTO_INCREMENT ,
  `ano` VARCHAR(45) NULL ,
  `Planhr_idPlanhr` INT NOT NULL ,
  PRIMARY KEY (`idAsigcat`) ,
  INDEX `fk_Asigcatedratico_Planhr1` (`Planhr_idPlanhr` ASC) ,
  CONSTRAINT `fk_Asigcatedratico_Planhr1`
    FOREIGN KEY (`Planhr_idPlanhr` )
    REFERENCES `Proyecto`.`Planhr` (`idPlanhr` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Proyecto`.`Detplanhr`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Proyecto`.`Detplanhr` (
  `Hinicio` VARCHAR(45) NULL ,
  `Hfin` VARCHAR(45) NULL ,
  `Dia` VARCHAR(45) NULL ,
  `Planhr_idPlanhr` INT NOT NULL ,
  `Rama_Cod_rama` INT NOT NULL ,
  `Ciclo_idCiclo` INT NOT NULL ,
  `Curso_Cod_curso` INT NOT NULL ,
  INDEX `fk_Detplanhr_Planhr1` (`Planhr_idPlanhr` ASC) ,
  INDEX `fk_Detplanhr_Rama1` (`Rama_Cod_rama` ASC) ,
  INDEX `fk_Detplanhr_Ciclo1` (`Ciclo_idCiclo` ASC) ,
  INDEX `fk_Detplanhr_Curso1` (`Curso_Cod_curso` ASC) ,
  CONSTRAINT `fk_Detplanhr_Planhr1`
    FOREIGN KEY (`Planhr_idPlanhr` )
    REFERENCES `Proyecto`.`Planhr` (`idPlanhr` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Detplanhr_Rama1`
    FOREIGN KEY (`Rama_Cod_rama` )
    REFERENCES `Proyecto`.`Rama` (`Cod_rama` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Detplanhr_Ciclo1`
    FOREIGN KEY (`Ciclo_idCiclo` )
    REFERENCES `Proyecto`.`Ciclo` (`idCiclo` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Detplanhr_Curso1`
    FOREIGN KEY (`Curso_Cod_curso` )
    REFERENCES `Proyecto`.`Curso` (`Cod_curso` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Proyecto`.`Detasigcat`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Proyecto`.`Detasigcat` (
  `Asigcatedratico_idAsigcat` INT NOT NULL ,
  `Rama_Cod_rama` INT NOT NULL ,
  `Ciclo_idCiclo` INT NOT NULL ,
  `Curso_Cod_curso` INT NOT NULL ,
  `Personal_idPersonal` INT NOT NULL ,
  INDEX `fk_Detasigcat_Asigcatedratico1` (`Asigcatedratico_idAsigcat` ASC) ,
  INDEX `fk_Detasigcat_Rama1` (`Rama_Cod_rama` ASC) ,
  INDEX `fk_Detasigcat_Ciclo1` (`Ciclo_idCiclo` ASC) ,
  INDEX `fk_Detasigcat_Curso1` (`Curso_Cod_curso` ASC) ,
  INDEX `fk_Detasigcat_Personal1` (`Personal_idPersonal` ASC) ,
  CONSTRAINT `fk_Detasigcat_Asigcatedratico1`
    FOREIGN KEY (`Asigcatedratico_idAsigcat` )
    REFERENCES `Proyecto`.`Asigcatedratico` (`idAsigcat` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Detasigcat_Rama1`
    FOREIGN KEY (`Rama_Cod_rama` )
    REFERENCES `Proyecto`.`Rama` (`Cod_rama` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Detasigcat_Ciclo1`
    FOREIGN KEY (`Ciclo_idCiclo` )
    REFERENCES `Proyecto`.`Ciclo` (`idCiclo` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Detasigcat_Curso1`
    FOREIGN KEY (`Curso_Cod_curso` )
    REFERENCES `Proyecto`.`Curso` (`Cod_curso` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Detasigcat_Personal1`
    FOREIGN KEY (`Personal_idPersonal` )
    REFERENCES `Proyecto`.`Personal` (`idPersonal` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

USE `Proyecto` ;

-- -----------------------------------------------------
-- Placeholder table for view `Proyecto`.`view1`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Proyecto`.`view1` (`id` INT);

-- -----------------------------------------------------
-- View `Proyecto`.`view1`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Proyecto`.`view1`;
USE `Proyecto`;
;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
