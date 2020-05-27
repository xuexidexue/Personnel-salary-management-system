/*
SQLyog Enterprise v12.09 (64 bit)
MySQL - 5.7.20 : Database - hr
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`hr` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `hr`;

/*Table structure for table `department_info` */

DROP TABLE IF EXISTS `department_info`;

CREATE TABLE `department_info` (
  `id` int(6) NOT NULL AUTO_INCREMENT,
  `name` varchar(12) DEFAULT NULL COMMENT '部门名称',
  `basis` int(6) DEFAULT NULL COMMENT '基础工资',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

/*Data for the table `department_info` */

insert  into `department_info`(`id`,`name`,`basis`) values (1,'技术部',2001),(2,'实习',1000),(3,'软件',2000);

/*Table structure for table `staff_info` */

DROP TABLE IF EXISTS `staff_info`;

CREATE TABLE `staff_info` (
  `id` int(6) NOT NULL AUTO_INCREMENT,
  `name` varchar(12) DEFAULT NULL COMMENT '名称',
  `department_id` int(6) DEFAULT NULL COMMENT '部门编号',
  `password` varchar(12) DEFAULT NULL COMMENT '查询密码',
  `sex` varchar(1) DEFAULT NULL COMMENT '性别',
  `age` int(2) DEFAULT NULL COMMENT '年龄',
  `createdate` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT '创建时间',
  `post` varchar(12) DEFAULT NULL COMMENT '职位',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

/*Data for the table `staff_info` */

insert  into `staff_info`(`id`,`name`,`department_id`,`password`,`sex`,`age`,`createdate`,`post`) values (1,'张三',1,'456','男',22,'2019-12-08 15:21:19','基础'),(2,'历史',1,'456','男',23,'2019-12-08 15:21:07','无'),(6,'李四',1,'456','男',21,'2019-12-08 15:20:50','wu'),(7,'123',2,'123','女',21,'2019-11-25 18:47:38','无'),(8,'造请求',3,'123','男',21,'2019-12-20 08:06:30','无');

/*Table structure for table `user` */

DROP TABLE IF EXISTS `user`;

CREATE TABLE `user` (
  `id` int(6) NOT NULL AUTO_INCREMENT,
  `name` varchar(12) DEFAULT NULL,
  `password` varchar(12) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;

/*Data for the table `user` */

insert  into `user`(`id`,`name`,`password`) values (1,'root','123'),(2,'张三','123'),(3,'李四','456'),(10,'王五','123'),(11,'赵六','123');

/*Table structure for table `wage_info` */

DROP TABLE IF EXISTS `wage_info`;

CREATE TABLE `wage_info` (
  `id` int(6) NOT NULL AUTO_INCREMENT,
  `staff_id` int(6) DEFAULT NULL COMMENT '职员编号',
  `basis` int(6) DEFAULT NULL COMMENT '基础工资',
  `attendance` int(6) DEFAULT NULL COMMENT '考勤工资',
  `performance` int(6) DEFAULT NULL COMMENT '效绩工资',
  `other` int(7) DEFAULT NULL COMMENT '其它',
  `reason` varchar(20) DEFAULT NULL COMMENT '原因',
  `total` int(6) DEFAULT NULL COMMENT '综合',
  `createdate` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

/*Data for the table `wage_info` */

insert  into `wage_info`(`id`,`staff_id`,`basis`,`attendance`,`performance`,`other`,`reason`,`total`,`createdate`) values (1,1,2001,200,2000,100,'好',4301,'2019-11-25 20:34:11'),(2,2,2001,120,2000,-120,'差',4001,'2019-11-25 20:34:15'),(3,8,2000,120,450,100,'差',2670,'2019-12-20 08:07:15');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
