<div align="center">
  <h1>BodroTest</h1>
</div>

___

### Содержание
- [Описание](#описание)
- [Функциональные возможности](#функциональные-возможности)
- [Демонстрация](#демонстрация)
  - [Форма регистрации](#форма-регистрации)
  - [Форма с тестом (текст)](#форма-с-тестом-текст)
  - [Форма с тестом (изображения)](#форма-с-тестом-изображения)
  - [Форма с результатами](#форма-с-результатами)
- [Установка](#установка)
- [Применение](#применение)
___

## Описание

**BodroTest** — это тестовое приложение, предназначенное для оценки знаний пользователей. Приложение включает в себя различные типы вопросов.
___

## Функциональные возможности

* Регистрация пользователя.
* Тестирование с различными типами вопросов.
* Воспроизведение аудиофайлов в вопросах.
* Отображение изображений в вопросах.
* Поддержка пользовательских шрифтов.
* Отправка результатов тестирования по электронной почте.
___

## Демонстрация

### Форма регистрации
<img src="https://github.com/xannykov/BodroTest/blob/main/src/Screenshot_1.png"/>

### Форма с тестом (текст)
<img src="https://github.com/xannykov/BodroTest/blob/main/src/Screenshot_2.png"/>

### Форма с тестом (изображения)
<img src="https://github.com/xannykov/BodroTest/blob/main/src/Screenshot_3.png"/>

### Форма с результатами
<img src="https://github.com/xannykov/BodroTest/blob/main/src/Screenshot_4.png"/>

___
## Установка

Клонируйте репозиторий:

  ```sh
  git clone https://github.com/xannykov/BodroTest.git
  ```
___

## Применение

В *InitializeQuestions.cs* можно задать свои вопросы. В данном примере, первые 2 вопроса текстовые, далее идут вопросы с изображениями, их мы берём из *Resources.resx*, аналогично с вопросами содержащие музыку.

```js
List<Question> questions = new List<Question>
{
    // Text questions
    new Question("Question 1 ?",
        new List<string> {"Answer 1", "Answer 2", "Answer 3", "Answer 4"}, 0),
    new Question("Question 2 ?",
        new List<string> {"Answer 1", "Answer 2", "Answer 3", "Answer 4"}, 1),

    // Questions with images
    new Question("Question 3 ?",
        new List<string> {"Answer 1", "Answer 2", "Answer 3", "Answer 4"}, 2, Properties.Resources.Image1),
    new Question("Question 4 ?",
        new List<string> {"Answer 1", "Answer 2", "Answer 3", "Answer 4"}, 3, Properties.Resources.Image2),            
    
    // Questions with music
    new Question("Question 5 ?",
        new List<string> {"Answer 1", "Answer 2", "Answer 3", "Answer 4"}, 0, null , Properties.Resources.Music1),
    new Question("Question 6 ?",
        new List<string> {"Answer 1", "Answer 2", "Answer 3", "Answer 4"}, 1, null , Properties.Resources.Music2),
};
```
В данном приложении отправка результатов происходит на почту, которую вы укажите, например, я указывал свою почту в настройках SMTP-сервера и указал её в методе отправки результатов.

В *Form3.cs*, где происходит настройка SMTP-сервера в методе *SendEmail()* надо указать данные (почту) для отправки результатов.
```js
string smtpAddress = "smtp.email.com";  // Укажите сервер почты, на которую будут приходить результаты
int portNumber = 25;                    // Укажите порт сервера (по умолчанию 25)
bool enableSSL = true;
string emailFrom = "example@email.com"; // Укажите свою почту
string password = "password";           // Укажите пароль, сгенерированный почтой
```

Также укажите свой email в методе *buttonSendEmail_Click()* для того, чтобы результаты отправлялись к вам на почту.
```js
SendEmail("example@email.com", "Результаты теста", emailBody);
```
___


[def]: #содержание