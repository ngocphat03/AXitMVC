# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/).

## [1.0.0] - 2024-10-24

### Added
- Initial implementation of the MVC architecture for Unity.
- Created `BaseView<TModel, TController>` abstract class to handle base view logic.
- Added `IView<TModel, TController>` interface to standardize view structure.
- Added `IController<TModel>` interface for controller logic.
- Added `IModel` interface to represent data models.
- Basic `Awake()` function to initialize controller and model.
- Abstract `Init()` method for custom initialization logic in derived views.