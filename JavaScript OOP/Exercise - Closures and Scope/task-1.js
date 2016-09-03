'use strict';

function solve() {
    var library = (function() {
        var books = [];
        var categories = [];

        function listBooks(searchedParameter) {

            books.sort(function(firstBook, secondBook) {
                return firstBook.id - secondBook.id;
            });

            if (searchedParameter === undefined) {
                return books;
            } else if (searchedParameter.author) {
                return books.filter((book) => book.author === searchedParameter.author);
            } else if (searchedParameter.category) {
                return books.filter((book) => book.category === searchedParameter.category);
            } else {
                return books;
            }
        }

        function addBook(book) {
            book.ID = books.length + 1;

            isBookInfoValid(book);

            if (!isCategoryExist(book.category)) {
                categories.push(book.category);
            }

            books.push(book);

            return book;
        }

        function listCategories() {

            categories.sort(function(firstCategory, secondCategory) {
                return firstCategory.id - secondCategory.id;
            });

            return categories;
        }

        function isCategoryExist(category) {
            if (categories.indexOf(category) < 0) {
                return false;
            }
            return true;

            // categories.forEach((currentCategory) => {
            //     if (currentCategory === category) {
            //         return true;
            //     }
            // });

            // return false;
        }

        function isBookInfoValid(book) {

            if (book.isbn.length !== 10 && book.isbn.length !== 13) {
                throw new Error("Error");
            }

            if (book.author.length === 0) {
                throw new Error("Error");
            }

            if (book.title.length < 3 || book.title.length > 100) {
                throw new Error("Error");
            }

            // if (!isStringContainsValidSymbols(book.title)) {
            //     throw new Error("Error");
            // }

            if (book.category.length < 3 || book.category.length > 100) {
                throw new Error("Error");
            }

            // if (!isStringContainsValidSymbols(book.category)) {
            //     throw new Error("Error");
            // }

            if (isBookIsbnExist(book.isbn)) {
                throw new Error("Error");
            }

            if (isBookTitleExist(book.title)) {
                throw new Error("Error");
            }
            // let isBookIsbnLengthValid = book.isbn.length === 10 || book.isbn.length === 13;
            // let isBookAuthorValid = book.author.length !== 0;
            // let isBookTitleLengthValid = isStringLengthValid(book.title.length);
            // let isBookTitleSymbolsValid = isStringContainsValidSymbols(book.title);
            // let isBookCategoryLengthValid = isStringLengthValid(book.category.length);
            // let isBookCategorySymbolsValid = isStringContainsValidSymbols(book.category);
            // let isIsbnUnique = isBookIsbnUnique(book.isbn);
            // let isTitleUnique = isBookTitleUniqe(book.title);

            // if (isBookIsbnLengthValid && isBookAuthorValid &&
            //     isBookTitleLengthValid && isBookTitleSymbolsValid &&
            //     isBookCategoryLengthValid && isBookCategorySymbolsValid &&
            //     isIsbnUnique && isTitleUnique) {
            //     return true;
            // } else {
            //     return false;
            // }

            return true;
        }

        function isBookTitleExist(title) {
            // books.forEach((book) => {
            //     if (book.title === title) {
            //         return true;
            //     }
            // });
            // return false;

            for (let book of books) {
                if (book.title === title) {
                    return true;
                }
            }
            return false;
        }

        function isBookIsbnExist(isbn) {
            // books.forEach(book => {
            //     if (book.isbn === isbn) {
            //         return true;
            //     }
            // });
            // return false;

            for (let book of books) {
                if (book.isbn === isbn) {
                    return true;
                }
            }
            return false;
        }

        function isStringLengthValid(input) {
            let isLengthValid = input > 3 && input < 100;

            return isLengthValid;
        }

        function isStringContainsValidSymbols(input) {
            let validSymbols = /^[0-9a-zA-Z]+$/;
            if (input.match(validSymbols)) {
                return true;
            } else {
                return false;
            }
        }

        return {
            books: {
                list: listBooks,
                add: addBook
            },
            categories: {
                list: listCategories
            }
        };
    }());
    return library;
}

// var f = solve();
// f.books.add({
//     title: 'Ivan',
//     isbn: '1234567890',
//     author: 'John Doe',
//     category: 'Coding'
// });

// f.books.add({
//     title: 'Gosho',
//     isbn: '1234567890',
//     author: 'John Doe',
//     category: 'Book Category'
// });

// f.books.add({
//     title: 'Ivan',
//     isbn: '1234567890',
//     author: 'John Doe',
//     category: 'Coding'
// });


// console.log(f.books.list({
//     category: 'Book Category'
// }));

module.exports = solve;