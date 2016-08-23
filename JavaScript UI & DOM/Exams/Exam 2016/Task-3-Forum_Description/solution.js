function solve() {
    return function() {
        var template = [

            '<h1>{{{title}}}</h1>',
            '<ul>',
            '{{#each posts}}',

            '{{#unless deleted}}',

            '<li>',
            '<div class="post">',
            '{{#if author}}',
            '<p class="author">',


            '<a class="user" href="/user/{{author}}">{{author}}</a>',


            '</p>',
            '<pre class="content">{{{text}}}</pre> ',
            '{{else}}',
            '<p class="author">',
            '<a class="anonymous">Anonymous</a>',
            '</p>',
            '<pre class="content">{{{text}}}</pre> ',
            '{{/if}}',
            '</div>',
            '<ul>',
            '{{#each comments}}',

            '{{#unless deleted}}',

            '<li>',


            '<div class="comment">',
            '{{#if author}}',
            '<p class="author">',

            '<a class="user" href="/user/{{author}}">{{author}}</a>',

            '</p>',
            '{{else}}',
            '<p class="author">',
            '<a class="anonymous">Anonymous</a>',
            '</p>',
            '{{/if}}',
            '<pre class="content">{{{text}}}</pre>',
            '</div>',



            '</li>',

            '{{/unless}}',

            '{{/each}}',
            '</ul>',
            '</li>',

            '{{/unless}}',

            '{{/each}}',
            '</ul>'



        ].join('\n');

        return template;
    };
}

// submit the above

if (typeof module !== 'undefined') {
    module.exports = solve;
}