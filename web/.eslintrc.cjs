module.exports = {
    root: true,
    env: {
        browser: true,
        es2020: true,
        node: true, // This is useful for recognizing global variables like module, require, etc.
    },
    parser: '@typescript-eslint/parser', // Use the TypeScript parser for ESLint
    parserOptions: {
        ecmaVersion: 'latest',
        sourceType: 'module',
        ecmaFeatures: {
            jsx: true, // Allows for the parsing of JSX
        },
    },
    settings: {
        react: {version: '18.2'},
        'import/resolver': {
            // This will help with module resolution
            node: {
                extensions: ['.js', '.jsx', '.ts', '.tsx'],
            },
        },
    },
    extends: [
        'eslint:recommended',
        'plugin:react/recommended',
        'plugin:react/jsx-runtime',
        'plugin:react-hooks/recommended',
        'plugin:@typescript-eslint/recommended', // Use the recommended rules from the @typescript-eslint/eslint-plugin
    ],
    ignorePatterns: ['dist', '.eslintrc.cjs'],
    plugins: [
        'react-refresh',
        '@typescript-eslint', // Include the plugin for TypeScript
    ],
    rules: {
        'react-refresh/only-export-components': [
            'warn',
            {allowConstantExport: true},
        ],
        // Add or modify rules as needed
    },
    overrides: [
        {
            // Enable the rule specifically for TypeScript files
            files: ['*.ts', '*.tsx'],
            rules: {
                'no-undef': 'off', // TypeScript's compiler already checks for undefined variables
            },
        },
    ],
};
