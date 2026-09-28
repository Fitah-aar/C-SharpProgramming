
<img width="959" height="504" alt="Example2" src="https://github.com/user-attachments/assets/ff69647b-b598-417b-8fdd-b10ccf67fe45" />




# Fikradaha Ugu Muhiimsan ee Naqshadaynta GUI (GUI Design Principles)

Faylkan wuxuu faahfaahin ka bixinayaa fikradaha muhiimka ah iyo xeerarka loo raacay naqshadaynta Interfayska Isticmaalaha (Graphical User Interface) ee barnaamijka Windows Forms.

---

## 1. U Hadafaynta Isticmaalaha (Labels)
* **Shaqada:** Isticmaalka kontaroolada `Label` si looga fogaado jahwareer.
* **Ujeeddada:** Waxay isticmaalaha u tusaysaa si muuqata halka uu xogta ka gelinayo iyo nooca xogta la rabbaa.
* **Tusaale:** `label1` oo muujinaya `"Enter Your First Name"`.

---

## 2. Qabashada Xogta (TextBoxes)
* **Shaqada:** Diyaarinta iyo dhigista kontaroolada `TextBox`.
* **Ujeeddada:** Waxay u oggolaanaysaa barnaamijka in uu ka qabto qoraallada iyo xogta uu isticmaaluhu ka soo geliyo keyboard-ka.
* **Tusaale:** `txtFirstName` oo qabanaya magaca koowaad.

---

## 3. Kiciyeyaasha Dhacdooyinka (Buttons)
* **Shaqada:** Isticmaalka kontaroolada `Button` si loogu kiciyo shaqooyinka ama koodhka barnaamijka.
* **Ujeeddada:** Marka isticmaaluhu riixo batoonka (Click Action), wuxuu kiciyaa Event Handler-ka C# ee ku xiran si uu u fuliyo shaqada loogu talagalay (sida isku-xidhka magacyada ama tirtiridda).
* **Tusaale:** `btnConcat` iyo `btnClear`.

---

## 4. Bixinta Magacyada Heerka Caalamiga ah (Standard Naming Conventions)
* **Shaqada:** Raacida qaabka heserka ah ee loogu magac daro kontaroolada barnaamijka C#.
* **Ujeeddada:** Waxay ka dhigaysaa koodhka mid habaysan, la akhriyi karo, maareyntiisuna ay faahfaahsan tahay iyadoo la isticmaalayo hor-dhiacyada (prefixes) heerka caalamiga ah:
  * **`txt`**: Waxaa loo isticmaalaa TextBoxes (tusaale: `txtFirstName`, `txtSecondName`).
  * **`lbl`**: Waxaa loo isticmaalaa Labels (tusaale: `lblFullName`).
  * **`btn`**: Waxaa loo isticmaalaa Buttons (tusaale: `btnConcat`, `btnClear`).

