# Тестовое задание

## Постановка

Реализовать систему администрирования отеля.
Требования к функционалу:

1. Система должна представлять собой web-приложение, имеющее страницу авторизации и страницу администрирования.

2. В БД системы должна иметься таблица пользователей, содержащая логины и хэши паролей.

3. Страница администрирования должна содержать таблицу номеров отеля с возможностью поиска и сортировки по различным полям.

4. Должна иметься операция заселения в номер при которой создается новая запись о посетителе с датой въезда.

5. Должна иметься операция выезда из номера, при которой номер освобождается и подсчитывается оплата в зависимости от типа номера, количества мест и времени.

## Предметная область

В отеле имеется определенное количество номеров.

У каждого номера имеется:

- вместимость;
- количество человек, которое может в нем проживать;
- тип: стандартный, полулюкс и люкс;
- состояние - занят или не занят;
- и т.п.

При въезде в номер создается запись в таблице:

- Посетитель: сущность, которая содержит:
  - ФИО
- дата въезда
- дата выезда.

Для системы авторизации должна иметься таблица пользователей, содержащая логин и хэш пароля.

Другие сущности могут создаваться на усмотрение.

## Техническая часть

Система должна быть реализована с использованием **ASP.NET Core**.

Для системы авторизации необходимо использовать **Identity**.

Для работы с БД **ORM Entity Framework Core**.

Желательно проектировать api с учетом **REST**.

Клиентская сторона (frontend) на усмотрение.

Дополнительный функционал приветствуется.

## Результат

`NULL` by allan_walpy