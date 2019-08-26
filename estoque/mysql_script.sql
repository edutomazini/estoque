CREATE DATABASE  IF NOT EXISTS `estoque` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;
USE `estoque`;


DROP TABLE IF EXISTS `categoria`;

CREATE TABLE `categoria` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=INNODB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;



DROP TABLE IF EXISTS `produto`;
CREATE TABLE `produto` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NOT NULL,
  `quantidade` INT(11) NOT NULL DEFAULT '0',
  `idcategoria` INT(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `idcategoria_idx` (`idcategoria`),
  CONSTRAINT `idcategoria` FOREIGN KEY (`idcategoria`) REFERENCES `categoria` (`id`)
) ENGINE=INNODB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_categoria_alterar`(ID_CATEGORIA INT, NOME VARCHAR(45))
BEGIN
	UPDATE categoria SET nome = NOME WHERE id = ID_CATEGORIA;
END ;;
DELIMITER ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_categoria_excluir`(ID_CATEGORIA INT)
BEGIN
	DELETE FROM categoria WHERE id = ID_CATEGORIA;
END ;;
DELIMITER ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_categoria_inserir`(NOME VARCHAR(45))
BEGIN
	INSERT INTO categoria (nome) VALUES (NOME);
	
END ;;
DELIMITER ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_categoria_listar`()
BEGIN
	SELECT * FROM categoria;
END ;;
DELIMITER ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_produto_alterar`(ID_PRODUTO INT, NOME VARCHAR(45), QUANTIDADE INT, ID_CATEGORIA INT)
BEGIN
	UPDATE produto SET nome = NOME, quantidade = QUANTIDADE, idcategoria = ID_CATEGORIA WHERE id = ID_PRODUTO;
END ;;
DELIMITER ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_produto_excluir`(ID_PRODUTO INT)
BEGIN
	DELETE FROM produto WHERE id = ID_PRODUTO;
END ;;
DELIMITER ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_produto_inserir`(NOME VARCHAR(45), QUANTIDADE INT, ID_CATEGORIA INT)
BEGIN
	INSERT INTO produto (nome, quantidade, idcategoria) VALUES (NOME, QUANTIDADE, ID_CATEGORIA);
END ;;
DELIMITER ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_produto_listar`()
BEGIN
	SELECT * FROM produto;
END ;;
DELIMITER ;

CREATE USER 'estoque'@'localhost' IDENTIFIED BY '123456';
GRANT ALL PRIVILEGES ON * . * TO 'estoque'@'localhost';