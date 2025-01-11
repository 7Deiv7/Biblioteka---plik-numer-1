# 📚 System Zarządzania Biblioteką 

  

## ✨ Opis projektu 

  

System Zarządzania Biblioteką to aplikacja webowa stworzona w technologii **ASP.NET MVC**. Umożliwia ona zarządzanie zasobami biblioteki, takimi jak książki, oraz udostępnia podstawowe funkcjonalności administracyjne.   

Aplikacja pozwala na przeglądanie, dodawanie, edytowanie oraz usuwanie książek. 

  

--- 

  

## 🏠 Strona startowa 

  

Po uruchomieniu aplikacji użytkownik zostaje przywitany na stronie głównej z napisem:   

**„Witamy na stronie startowej”.** 

  

Na górze strony znajduje się menu nawigacyjne z trzema opcjami: 

- **🏠 Home** – powrót na stronę główną. 

- **📖 Książki** – przejście do sekcji zarządzania książkami. 

- **🔙 Strona początkowa** – funkcja umożliwiająca powrót na stronę startową. 

  

--- 

  

## 📖 Sekcja książek 

  

W sekcji książek wyświetlany jest spis książek, które znajdują się w bazie danych.   

W projekcie wstępnie dodano trzy książki, które są ładowane automatycznie z kodu, oraz trzy dodatkowe pozycje, które można dodać ręcznie przez interfejs użytkownika. 

  

Dla każdej książki dostępne są następujące opcje: 

- **➕ Create** – tworzenie nowej książki. 

- **✏️ Edit** – edytowanie istniejącej pozycji. 

- **🗑️ Delete** – usuwanie książki. 

- **🔍 Details** – wyświetlanie szczegółowych informacji o książce. 

  

--- 

  

## ➕ Funkcja dodawania książki (Create) 

  

Formularz dodawania nowej książki zawiera pola: 

- **📚 Tytuł książki**. 

- **🔢 Numer książki** (unikalny identyfikator). 

- **🏷️ Kategoria** – wybór z dostępnych kategorii (3 predefiniowane kategorie). 

- **✍️ Autor** – wybór z listy autorów (5 predefiniowanych autorów). 

  

Po wypełnieniu formularza i zatwierdzeniu dane powinny zostać zapisane w bazie, a nowa pozycja pojawia się na liście książek. 

  

### 🛠️ Problemy techniczne: 

Obecnie występuje błąd w funkcji **Create**, który uniemożliwia dodanie nowej książki.   

Próby naprawienia tej funkcjonalności do tej pory nie przyniosły efektu. 

  

--- 

  

## 🔧 Pozostałe funkcje 

  

- **✏️ Edycja książki (Edit):** umożliwia modyfikację danych dotyczących istniejących książek. 

- **🗑️ Usuwanie książki (Delete):** usuwa książkę z bazy danych. 

- **🔍 Szczegóły książki (Details):** wyświetla wszystkie informacje o wybranej książce. 

  

--- 

  

## 📌 Podsumowanie 

  

Projekt to podstawowy system zarządzania książkami w bibliotece, umożliwiający: 

- przeglądanie, 

- dodawanie, 

- edytowanie, 

- oraz usuwanie pozycji książkowych. 

  

Interfejs użytkownika jest prosty i intuicyjny, a wszystkie funkcje (poza dodawaniem książek, które obecnie wymaga poprawy) działają zgodnie z założeniami.   

System wykorzystuje **Entity Framework** do obsługi bazy danych, co pozwala na łatwą integrację oraz zarządzanie danymi. 

  

Dalsze prace nad naprawieniem funkcji dodawania książek są w toku, aby w pełni uruchomić tę funkcjonalność i umożliwić użytkownikom korzystanie z niej bez przeszkód. 

  

--- 

  

## 💻 Technologie użyte w projekcie: 

- **🖥️ Język programowania:** C# 

- **🌐 Framework:** ASP.NET MVC 

- **📦 ORM:** Entity Framework 

- **💾 Baza danych:** SQL Server 

- **🎨 Stylizacja:** Bootstrap 

  

--- 
