// See https://aka.ms/new-console-template for more information
using OOP3;
// demekki intefacelerde o interfaceyi impelemet eden class ın referans nosunu tutabiliyor.

//IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
//ihtiyacKrediManager.Hesapla();
//TasıtKrediManager tasıtKrediManager = new TasıtKrediManager();
//tasıtKrediManager.Hesapla();
//KonutKrediManager konutKrediManager = new KonutKrediManager();
//konutKrediManager.Hesapla();

// yukardakileri seçili eleman gibi düşün seçilcek

IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();


TasıtKrediManager tasıtKrediManager = new TasıtKrediManager();


KonutKrediManager konutKrediManager = new KonutKrediManager();

BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(tasıtKrediManager);
// yani başvuru yapılan kredinin hesaplandı.// çok önemli



