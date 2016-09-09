function solve() {
    const getId = (function() {
        let id = 0;

        return function() {
            id += 1;
            return id;
        };
    }());

    const MIN_STRING_LENGTH = 3;
    const MAX_STRING_LENGTH = 25;

    class Validator {
        static validateString(input) {
            if (input === null) {
                throw new Error("Value can not be null.");
            }

            if (input === undefined || typeof input !== "string") {
                throw new Error("Value must be string");
            }

            if (input.length < MIN_STRING_LENGTH || input.length > MAX_STRING_LENGTH) {
                throw new Error("Value length must be between 3 and 25 characters.");
            }
        }

        static validateNumber(input) {
            if (input <= 0) {
                throw new Error("Value must be greater than 0.");
            }
        }

        static validateObject(input) {
            if (input === null || input === undefined) {
                throw new Error("Passed parameter can not be null or undefined.");
            }
        }
    }

    class Player {
        constructor(name) {
            this.name = name;
            this._entries = [];
        }

        get size() {
            return this._entries.length;
        }

        get name() {
            return this._name;
        }

        set name(value) {
            Validator.validateString(value);
            this._name = value;
        }

        addPlaylist(input) {
            Validator.validateObject(input);
            if (input instanceof Playlist) { //obj.constructor.name
                this._entries.push(input);
            } else {
                throw new Error("You can add only playlist to the player.")
            }

            return this;
        }

        getPlaylistById(id) {
            Validator.validateNumber(id);

            let searchedPlaylist;

            this._entries.forEach((entry) => {
                if (entry.id === id) {
                    searchedPlaylist = entry;
                }
            });

            if (searchedPlaylist !== undefined) {
                return searchedPlaylist;
            } else {
                return null;
            }
        }

        removePlaylist(playlist) {
            let searchedId;

            if (playlist instanceof Playlist) {
                searchedId = playlist.id;
            }

            if (searchedId !== undefined) {
                this._entries = this._entries.filter(function(entry) {
                    return entry.id !== searchedId;
                });
            } else {
                throw new Error("Playlist with this id does not exist in the player.");
            }

            return this;
        }

        listPlaylists(page, size) {
            let COUNT_OF_PLAYABLE_IN_PLAYLIST = this._entries.length;
            let neededPlaylists = [];

            if (page * size > COUNT_OF_PLAYABLE_IN_PLAYLIST) {
                throw new Error("Maximum size exceded");
            }

            if (page < 0) {
                throw new Error("Page you are trying to reach must be equal or greater than 0.");
            }

            if (size <= 0) {
                throw new Error("Size of the page must be positive number.");
            }

            this._entries.sort(function(a, b) {
                if (a.name < b.name) {
                    return -1;
                } else if (a.title > b.title) {
                    return 1;
                } else {
                    return a.id - b.id;
                }
            });

            this._entries.forEach((entry) => {
                console.log(entry.play());
            });

            if (COUNT_OF_PLAYABLE_IN_PLAYLIST <= size) {
                neededPlaylists = this._entries;
            } else {
                let startIndex = (page) * size;
                let endIndex = startIndex + size;
                if (startIndex + size > COUNT_OF_PLAYABLE_IN_PLAYLIST) {
                    endIndex = COUNT_OF_PLAYABLE_IN_PLAYLIST;
                }

                for (let i = startIndex; i < endIndex; i += 1) {
                    neededPlaylists.push(this._entries[i]);
                }
            }

            neededPlaylists.forEach((entry) => {
                console.log(entry.play());
            });

            //return neededPlaylists;
        }

    }

    class Playlist {
        constructor(name) {
            this._id = getId();
            this.name = name;
            this._entries = [];
        }

        get id() {
            return this._id;
        }

        get size() {
            return this._entries.length;
        }

        get name() {
            return this._name;
        }

        set name(value) {
            Validator.validateString(value);
            this._name = value;
        }

        addPlayable(input) {
            Validator.validateObject(input);
            if (input instanceof Playable) { //obj.constructor.name
                this._entries.push(input);
            }

            return this;
        }

        getPlayableById(id) {
            Validator.validateNumber(id);

            let searchedPlayable;

            this._entries.forEach((entry) => {
                if (entry.id === id) {
                    searchedPlayable = entry;
                }
            });

            if (searchedPlayable !== undefined) {
                return searchedPlayable;
            } else {
                return null;
            }
        }

        removePlayable(input) {
            let searchedId;

            if (typeof input === "number") {
                searchedId = input;
            }

            if (input instanceof Playable) {
                searchedId = input.id;
            }

            if (searchedId !== undefined) {
                this._entries = this._entries.filter(function(entry) {
                    return entry.id !== searchedId;
                });
            } else {
                throw new Error("Playable with this id does not exist in the playlist.");
            }

            return this;
        }

        listPlayables(page, size) {
            let COUNT_OF_PLAYABLE_IN_PLAYLIST = this._entries.length;
            let neededPlayable = [];

            if (page * size > COUNT_OF_PLAYABLE_IN_PLAYLIST) {
                throw new Error("Maximum size exceded");
            }

            if (page < 0) {
                throw new Error("Page you are trying to reach must be equal or greater than 0.");
            }

            if (size <= 0) {
                throw new Error("Size of the page must be positive number.");
            }

            this._entries.sort(function(a, b) {
                if (a.title < b.title) {
                    return -1;
                } else if (a.title > b.title) {
                    return 1;
                } else {
                    return a.id - b.id;
                }
            });

            // this._entries.forEach((entry) => {
            //     console.log(entry.play());
            // });

            if (COUNT_OF_PLAYABLE_IN_PLAYLIST <= size) {
                neededPlayable = this._entries;
            } else {
                let startIndex = (page) * size;
                let endIndex = startIndex + size;
                if (startIndex + size > COUNT_OF_PLAYABLE_IN_PLAYLIST) {
                    endIndex = COUNT_OF_PLAYABLE_IN_PLAYLIST;
                }

                for (let i = startIndex; i < endIndex; i += 1) {
                    neededPlayable.push(this._entries[i]);
                }
            }

            // neededPlayable.forEach((entry) => {
            //     console.log(entry.play());
            // });

            return neededPlayable;
        }
    }

    class Playable {
        constructor(title, author) {
            this._id = getId();
            this.title = title;
            this.author = author;
        }

        get id() {
            return this._id;
        }

        get title() {
            return this._title;
        }

        set title(value) {
            Validator.validateString(value);
            this._title = value;
        }

        get author() {
            return this._author;
        }

        set author(value) {
            Validator.validateString(value);
            this._author = value;
        }

        play() {
            return `${this._id}. ${this._title} - ${this._author}`;
        }
    }

    class Audio extends Playable {
        constructor(title, author, length) {
            super(title, author);
            this.length = length;
        }

        get length() {
            return this._length;
        }

        set length(value) {
            Validator.validateNumber(value);
            this._length = value;
        }

        play() {
            return super.play() + ` - ${this._length}`;
        }
    }

    class Video extends Playable {
        constructor(title, author, imdbRating) {
            super(title, author);
            this.imdbRating = imdbRating;
        }

        get imdbRating() {
            return this._imdbRating;
        }

        set imdbRating(value) {
            Validator.validateNumber(value);
            this._imdbRating = value;
        }

        play() {
            return super.play() + ` - ${this._imdbRating}`;
        }
    }

    function getPlayer(name) {
        // returns a new player instance with the provided name
    }

    function getPlaylist(name) {
        return new Playlist(name);
    }

    function getAudio(title, author, length) {
        return new Audio(title, author, length);
    }

    function getVideo(title, author, imdbRating) {
        return new Video(title, author, imdbRating);
    }

    return { getPlayer, getPlaylist, getAudio, getVideo };
}

//module.exports(solve);

let player = solve();

let techno1 = player.getAudio("Jaguar", "Ben Sims", 55.05);

let audio = player.getAudio("Komm", "Sven Vath", 3.45);
// console.log(audio.play());

let video = player.getVideo("Pod Prikritie 3", "BNT", 720);
// console.log(video.play());

let techno = player.getAudio("Jaguar", "Mauro Piccoto", 55.05);

let popFolk = player.getAudio("Kokoroko", "Unknown", 5.43);
let bg = player.getAudio("Chereshi", "Tonika", 2.34);
let pop = player.getAudio("Lover", "Madonna", 3.13);


let playList = player.getPlaylist("new playList");

playList.addPlayable(bg);
playList.addPlayable(audio);
playList.addPlayable(video);
playList.addPlayable(techno);
playList.addPlayable(techno1);
playList.addPlayable(pop);
playList.addPlayable(popFolk);


// console.log(playList.getPlayableById(1));
// console.log(playList.getPlayableById(2));

// playList.removePlayable(1);

// console.log(playList.getPlayableById(1));
// playList.removePlayable(1);

// playList.removePlayable(1).removePlayable(2);

// console.log(playList.getPlayableById(1));
// console.log(playList.getPlayableById(2));

// playList.removePlayable(video).removePlayable(1).removePlayable("ewewe");

// console.log(playList.getPlayableById(1));
// console.log(playList.getPlayableById(2));

playList.listPlayables(2, 3);