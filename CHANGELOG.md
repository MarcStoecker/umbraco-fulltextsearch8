# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

- Changed the config format #35 **BREAKING**
- Switch to using RenderTemplate() for getting the content #36 **BREAKING**
- Only index nodes with a template and check umbracoNaviHide #27
- Adding a doctype to DisallowedContentTypeAliases doesn't remove already indexed pages #29
- When HighlightSearchTerms = true, ellipsis are always shown #23
- Fuzzy search does not return expected values #25
- No results returned if you do not have "Allow varying by culture" set to true on document type. #4
- No results when no specific culture is used #17
- Search returns 0 result with culture set #24

## [0.2.0] - 2020-04-02
Lot's of improvements and fixes, for example v8.6 upgrade problems fixed and non-variant websites support.

## [0.1.0] - 2019-10-01
Initial release

[unreleased]: https://github.com/skttl/umbraco-fulltextsearch8/compare/v0.2.0...HEAD
[0.2.0]: https://github.com/skttl/umbraco-fulltextsearch8/compare/v0.1.0...v0.2.0
[0.1.0]: https://github.com/skttl/umbraco-fulltextsearch8/releases/tag/v0.1.0
