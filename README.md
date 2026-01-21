# It-Legend C OOP Projects

A collection of small C projects and examples designed for learning and practicing Object-Oriented Programming (OOP) techniques using C-style patterns and modular design. This repository is intended as a training playground: focused exercises demonstrating OOP concepts (encapsulation, modularity, interface-like patterns) that are easy to extend.

---

## Goals

- Provide clear, small projects that demonstrate OOP concepts in C (encapsulation via structs + functions, interface-like patterns, modularity).
- Offer a stable structure that is easy to extend and reuse.
- Serve as a reusable training repository for exercises, examples, and incremental projects.

---

## Repository structure

- projects/
  - project-1-name/
    - src/        — source files
    - include/    — public headers
    - tests/      — tests / example usage
    - README.md   — per-project notes
  - project-2-name/
- docs/          — design notes, UML diagrams, extension ideas
- examples/      — small runnable examples
- .github/workflows/ — CI (recommended)
- CONTRIBUTING.md
- README.md

---

## How to use

1. Clone the repo:
   git clone https://github.com/MohamadAymanZarad/It-Legend-C-OOP-Projects.git
2. Open a project folder under `projects/`.
3. Read that project's `README.md` to see build/run instructions.
4. Build with the provided Makefile or compile manually, for example:
   make -C projects/project-1-name
5. Inspect `include/` for the public API and `src/` for implementation—this separation simulates OOP encapsulation.

---

## OOP patterns demonstrated

- Encapsulation: use `struct` + internal source files to hide implementation details.
- Module interfaces: provide header files as "public" interfaces; keep internals in `.c` files.
- Polymorphism-like patterns: use function pointers in structs to simulate virtual methods.
- Composition: build complex behavior by composing smaller modules.

---

## How to extend

- Add new modules under `projects/<project>/src` and expose APIs in `include/`.
- Add unit tests under `tests/` (recommend CUnit, Unity, or simple assert-based tests).
- Add CI (GitHub Actions) to run builds and tests automatically.
- Add design docs and sequence/class diagrams under `docs/`.

---

## Contribution

- Create an issue describing the feature or improvement.
- Fork, work on a branch `feature/<short-desc>`, commit, and open a PR.
- Add tests and update the project's README when you add features.

---

## Roadmap (example)

- [ ] Add CI build & test workflow
- [ ] Add 5 initial projects demonstrating key OOP patterns
- [ ] Add exercises and solutions
- [ ] Add tutorial notes for each project

---

## License

This repository is available under the MIT License. See LICENSE for details.

---

## Contact

Owner: MohamadAymanZarad (Mohamad Zarad)