-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Янв 12 2021 г., 10:08
-- Версия сервера: 10.3.13-MariaDB
-- Версия PHP: 7.1.22

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `test`
--

-- --------------------------------------------------------

--
-- Структура таблицы `cources`
--

CREATE TABLE `cources` (
  `id` int(11) NOT NULL,
  `name_cource` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `cources`
--

INSERT INTO `cources` (`id`, `name_cource`) VALUES
(1, 'Программирование'),
(2, 'sql'),
(3, 'xml');

-- --------------------------------------------------------

--
-- Структура таблицы `scores`
--

CREATE TABLE `scores` (
  `id` int(11) NOT NULL,
  `cource` int(11) NOT NULL,
  `student` int(11) NOT NULL,
  `score` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `scores`
--

INSERT INTO `scores` (`id`, `cource`, `student`, `score`) VALUES
(3, 1, 3, 5),
(4, 1, 2, 4),
(5, 1, 4, 3),
(6, 1, 1, 2),
(7, 2, 3, 2),
(8, 2, 2, 3),
(9, 2, 4, 4),
(10, 2, 1, 5),
(11, 3, 3, 5),
(12, 3, 2, 4),
(13, 3, 4, 3),
(14, 3, 1, 2),
(19, 2, 3, 2),
(20, 2, 2, 3),
(21, 2, 4, 4),
(22, 2, 1, 5),
(23, 3, 3, 5),
(24, 3, 2, 4),
(25, 3, 4, 3),
(26, 3, 1, 2);

-- --------------------------------------------------------

--
-- Структура таблицы `students`
--

CREATE TABLE `students` (
  `id` int(11) NOT NULL,
  `FIO` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `students`
--

INSERT INTO `students` (`id`, `FIO`) VALUES
(1, 'петров'),
(2, 'иванов'),
(3, 'Валиев'),
(4, 'козлов');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `cources`
--
ALTER TABLE `cources`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `scores`
--
ALTER TABLE `scores`
  ADD PRIMARY KEY (`id`),
  ADD KEY `cource` (`cource`),
  ADD KEY `student` (`student`);

--
-- Индексы таблицы `students`
--
ALTER TABLE `students`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `cources`
--
ALTER TABLE `cources`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `scores`
--
ALTER TABLE `scores`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT для таблицы `students`
--
ALTER TABLE `students`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `scores`
--
ALTER TABLE `scores`
  ADD CONSTRAINT `scores_ibfk_1` FOREIGN KEY (`cource`) REFERENCES `cources` (`id`),
  ADD CONSTRAINT `scores_ibfk_2` FOREIGN KEY (`student`) REFERENCES `students` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
