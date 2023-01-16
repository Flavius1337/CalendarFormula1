using CalendarFormula1.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace CalendarFormula1.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                //Piloti
                if (!context.Pilotii.Any())
                {
                    context.Pilotii.AddRange(new List<Piloti>()
                    {
                        new Piloti()
                        {
                            ProfilePictureURL = "https://www.formula1.com/content/fom-website/en/drivers/charles-leclerc/jcr:content/image.img.640.medium.jpg/1670254511194.jpg",
                            NumePilot = "Charles Leclerc",
                            NumarPilot = 16,
                            Echipa = "Ferrari"
                        }
                        ,
                        new Piloti()
                        {
                            NumePilot = "Carlos Sainz",
                            NumarPilot = 55,
                            ProfilePictureURL = "https://www.formula1.com/content/fom-website/en/drivers/carlos-sainz/jcr:content/image.img.640.medium.jpg/1669048713347.jpg",
                            Echipa = "Ferrari"
                        },
                        new Piloti()
                        {
                            NumePilot = "Max Verstappen",
                            NumarPilot = 1,
                            ProfilePictureURL = "https://www.formula1.com/content/fom-website/en/drivers/max-verstappen/jcr:content/image.img.640.medium.jpg/1670841844162.jpg",
                            Echipa = "Red Bull Racing"
                        },
                        new Piloti()
                        {
                            NumePilot = "Sergio Perez",
                            NumarPilot = 11,
                            ProfilePictureURL = "https://www.formula1.com/content/fom-website/en/drivers/sergio-perez/jcr:content/image.img.640.medium.jpg/1669048529570.jpg",
                            Echipa = "Red Bull Racing"
                        },
                        new Piloti()
                        {
                            NumePilot = "Lewis Hamilton",
                            NumarPilot = 44,
                            ProfilePictureURL = "https://www.formula1.com/content/fom-website/en/drivers/lewis-hamilton/jcr:content/image.img.640.medium.jpg/1647334259839.jpg",
                            Echipa = "Mercedes Amg Petronas"
                        },
                        new Piloti()
                        {
                            NumePilot = "George Russell",
                            NumarPilot = 63,
                            ProfilePictureURL = "https://www.formula1.com/content/fom-website/en/drivers/george-russell/jcr:content/image.img.640.medium.jpg/1670253611700.jpg",
                            Echipa = "Mercedes Amg Petronas"
                        },
                        new Piloti()
                        {
                            NumePilot = "Lando Norris",
                            NumarPilot = 4,
                            ProfilePictureURL = "https://www.formula1.com/content/fom-website/en/drivers/lando-norris/jcr:content/image.img.640.medium.jpg/1669045255181.jpg",
                            Echipa = "McLaren F1 Team"
                        }
                    });
                    context.SaveChanges();
                    //Tara
                    if (!context.Taraa.Any())
                    {
                        context.Taraa.AddRange(new List<Tara>()
                        {
                            new Tara()
                            {
                                NumeTara = "Bahrain",
                                Oras = "Sakir",
                                PictureURL = "https://cdn.britannica.com/67/5767-004-E0FF7201/Flag-Bahrain.jpg"
                            },
                            new Tara()
                            {
                                NumeTara = "Arabia Saudita",
                                Oras = "Jeddah",
                                PictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Flag_of_Saudi_Arabia.svg/2000px-Flag_of_Saudi_Arabia.svg.png"
                            },
                            new Tara()
                            {
                                NumeTara = "Australia",
                                Oras = "Melbourne",
                                PictureURL = "https://upload.wikimedia.org/wikipedia/commons/8/88/Flag_of_Australia_%28converted%29.svg"
                            },
                            new Tara()
                            {
                                NumeTara = "Italia",
                                Oras = "Imola",
                                PictureURL = "https://upload.wikimedia.org/wikipedia/en/thumb/0/03/Flag_of_Italy.svg/255px-Flag_of_Italy.svg.png"
                            },
                            new Tara()
                            {
                                NumeTara = "Italia",
                                Oras = "Monza",
                                PictureURL = "https://upload.wikimedia.org/wikipedia/en/thumb/0/03/Flag_of_Italy.svg/255px-Flag_of_Italy.svg.png"
                            },
                            new Tara()
                            {
                                NumeTara = "Statele Unite ale Americii",
                                Oras = "Miami",
                                PictureURL = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a4/Flag_of_the_United_States.svg/1200px-Flag_of_the_United_States.svg.png"
                            },
                            new Tara()
                            {
                                NumeTara = "Statele Unite ale Americii",
                                Oras = "Texas",
                                PictureURL = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a4/Flag_of_the_United_States.svg/1200px-Flag_of_the_United_States.svg.png"
                            },
                            new Tara()
                            {
                                NumeTara = "Spania",
                                Oras = "Barcelona",
                                PictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/89/Bandera_de_Espa%C3%B1a.svg/1200px-Bandera_de_Espa%C3%B1a.svg.png"
                            },
                            new Tara()
                            {
                                NumeTara = "Monaco",
                                Oras = "Monaco",
                                PictureURL = "https://cdn.britannica.com/50/2750-004-A9D00172/Flag-Monaco.jpg"
                            },
                            new Tara()
                            {
                                NumeTara = "Azerbaijan",
                                Oras = "Baku",
                                PictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/dd/Flag_of_Azerbaijan.svg/1200px-Flag_of_Azerbaijan.svg.png"
                            },
                            new Tara()
                            {
                                NumeTara = "Canada",
                                Oras = "Montreal",
                                PictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cf/Flag_of_Canada.svg/2560px-Flag_of_Canada.svg.png"
                            },
                            new Tara()
                            {
                                NumeTara = "Marea Britanie",
                                Oras = "Northamptonshire",
                                PictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/Flag_of_the_United_Kingdom_%283-5%29.svg/300px-Flag_of_the_United_Kingdom_%283-5%29.svg.png"
                            },
                            new Tara()
                            {
                                NumeTara = "Austria",
                                Oras = "Spielberg",
                                PictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/41/Flag_of_Austria.svg/255px-Flag_of_Austria.svg.png"
                            },
                            new Tara()
                            {
                                NumeTara = "Franta",
                                Oras = "Le Castellet",
                                PictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/18/Flag_of_France_%28lighter_variant%29.svg/250px-Flag_of_France_%28lighter_variant%29.svg.png"
                            },
                            new Tara()
                            {
                                NumeTara = "Ungaria",
                                Oras = "Budapesta",
                                PictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c1/Flag_of_Hungary.svg/2560px-Flag_of_Hungary.svg.png"
                            },
                            new Tara()
                            {
                                NumeTara = "Belgia",
                                Oras = "Spa-Frncorchamps",
                                PictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/65/Flag_of_Belgium.svg/692px-Flag_of_Belgium.svg.png"
                            },
                            new Tara()
                            {
                                NumeTara = "Olanda",
                                Oras = "Zandvoort",
                                PictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Flag_of_the_Netherlands.svg/1280px-Flag_of_the_Netherlands.svg.png"
                            },
                            new Tara()
                            {
                                NumeTara = "Singapore",
                                Oras = "Marina Bay",
                                PictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/48/Flag_of_Singapore.svg/1200px-Flag_of_Singapore.svg.png"
                            },
                            new Tara()
                            {
                                NumeTara = "Japonia",
                                Oras = "Suzuka",
                                PictureURL = "https://upload.wikimedia.org/wikipedia/en/thumb/9/9e/Flag_of_Japan.svg/1200px-Flag_of_Japan.svg.png"
                            },
                            new Tara()
                            {
                                NumeTara = "Mexic",
                                Oras = "Mexico City",
                                PictureURL = "https://cdn.britannica.com/73/2573-004-29818847/Flag-Mexico.jpg"
                            },
                            new Tara()
                            {
                                NumeTara = "Brazilia",
                                Oras = "Sao Paulo",
                                PictureURL = "https://upload.wikimedia.org/wikipedia/en/thumb/0/05/Flag_of_Brazil.svg/640px-Flag_of_Brazil.svg.png"
                            },
                            new Tara()
                            {
                                NumeTara = "Abu Dhabi",
                                Oras = "Yas Island",
                                PictureURL = "https://www.shutterstock.com/image-vector/united-arab-emirates-flag-isolated-260nw-561114565.jpg"
                            }
                        });
                        context.SaveChanges();
                        //Cursa
                        if (!context.Cursaa.Any())
                        {
                            context.Cursaa.AddRange(new List<Cursa>()
                            {
                                new Cursa()
                                {
                                    NumeCursa = "FORMULA 1 GULF AIR BAHRAIN GRAND PRIX 2022",
                                    Descriere = "Ferrari make the perfect start to 2022 with a Leclerc-Sainz 1-2",
                                    ImageURL = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Track%20icons%204x3/Bahrain%20carbon.png.transform/3col-retina/image.png",
                                    DataCursa = 20.03,
                                    CategorieCircuit = Enums.CategorieCircuit.Pista,
                                    TaraId = 1,
                                    Pret = 30.00
                                },
                                new Cursa()
                                {
                                    NumeCursa = "FORMULA 1 STC SAUDI ARABIAN GRAND PRIX 2022",
                                    Descriere = "Verstappen edges Leclerc by half a second in Saudi Arabian thriller",
                                    ImageURL = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Track%20icons%204x3/Saudi%20Arabia%20carbon.png.transform/4col-retina/image.png",
                                    DataCursa = 27.03,
                                    CategorieCircuit= Enums.CategorieCircuit.Stradal,
                                    TaraId = 2,
                                    Pret = 30.00


                                },
                                new Cursa()
                                {
                                    NumeCursa = "FORMULA 1 HEINEKEN AUSTRALIAN GRAND PRIX 2022",
                                    Descriere = "Leclerc takes commanding Melbourne win as Verstappen fails to finish",
                                    ImageURL = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Track%20icons%204x3/Australia%20carbon.png.transform/4col-retina/image.png",
                                    DataCursa = 10.04,
                                    CategorieCircuit = Enums.CategorieCircuit.Pista,
                                    TaraId = 3,
                                    Pret = 30.00
                                },
                                new Cursa()
                                {
                                    NumeCursa = "FORMULA 1 ROLEX GRAN PREMIO DEL MADE IN ITALY E DELL'EMILIA-ROMAGNA 2022",
                                    Descriere = "Verstappen heads Red Bull 1-2 in difficult home race for Ferrari",
                                    ImageURL = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Track%20icons%204x3/Emilia%20Romagna%20carbon.png.transform/4col-retina/image.png",
                                    DataCursa = 24.04,
                                    CategorieCircuit = Enums.CategorieCircuit.Pista,
                                    TaraId = 4,
                                    Pret = 30.00
                                },
                                new Cursa()
                                {
                                    NumeCursa = "FORMULA 1 CRYPTO.COM MIAMI GRAND PRIX 2022",
                                    Descriere = "Verstappen victory in Miami closes championship gap to Leclerc",
                                    ImageURL = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Track%20icons%204x3/Miami%20carbon.png.transform/4col-retina/image.png",
                                    DataCursa = 08.05,
                                    CategorieCircuit= Enums.CategorieCircuit.Stradal,
                                    TaraId = 6,
                                    Pret = 30.00
                                },
                                new Cursa()
                                {
                                    NumeCursa = "FORMULA 1 PIRELLI GRAN PREMIO DE ESPAÑA 2022",
                                    Descriere = "Victory gives Verstappen title lead as Leclerc retires in Barcelona",
                                    ImageURL = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Track%20icons%204x3/Spain%20carbon.png.transform/4col-retina/image.png",
                                    DataCursa = 22.05,
                                    CategorieCircuit = Enums.CategorieCircuit.Pista,
                                    TaraId = 8,
                                    Pret = 30.00
                                },
                                new Cursa()
                                {
                                    NumeCursa = "FORMULA 1 GRAND PRIX DE MONACO 2022",
                                    Descriere = "Perez wins from Sainz in incident-packed wet-dry Monaco thriller",
                                    ImageURL = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Track%20icons%204x3/Monte%20Carlo%20carbon.png.transform/4col-retina/image.png",
                                    DataCursa = 29.05,
                                    CategorieCircuit= Enums.CategorieCircuit.Stradal,
                                    TaraId = 9,
                                    Pret = 30.00
                                },
                                new Cursa()
                                {
                                    NumeCursa = "FORMULA 1 AZERBAIJAN GRAND PRIX 2022",
                                    Descriere = "Verstappen heads Red Bull 1-2 in Baku as Ferrari suffer double DNF",
                                    ImageURL = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Track%20icons%204x3/Azerbaijan%20carbon.png.transform/4col-retina/image.png",
                                    DataCursa = 12.06,
                                    CategorieCircuit = Enums.CategorieCircuit.Pista,
                                    TaraId = 10,
                                    Pret = 30.00
                                },
                                new Cursa()
                                {
                                    NumeCursa = "FORMULA 1 AWS GRAND PRIX DU CANADA 2022",
                                    Descriere = "Verstappen controls Montreal race and holds off Sainz for victory",
                                    ImageURL = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Track%20icons%204x3/Canada%20carbon.png.transform/4col-retina/image.png",
                                    DataCursa = 19.06,
                                    CategorieCircuit = Enums.CategorieCircuit.Pista,
                                    TaraId = 11,
                                    Pret = 30.00
                                },
                                new Cursa()
                                {
                                    NumeCursa = "FORMULA 1 LENOVO BRITISH GRAND PRIX 2022",
                                    Descriere = "Sainz takes maiden win from Perez in action-packed British Grand Prix",
                                    ImageURL = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Track%20icons%204x3/Great%20Britain%20carbon.png.transform/4col-retina/image.png",
                                    DataCursa = 03.07,
                                    CategorieCircuit = Enums.CategorieCircuit.Pista,
                                    TaraId = 12,
                                    Pret = 30.00
                                },
                                new Cursa()
                                {
                                    NumeCursa = "FORMULA 1 ROLEX GROSSER PREIS VON ÖSTERREICH 2022",
                                    Descriere = "Leclerc holds on to beat Verstappen as Ferrari take victory in Austria",
                                    ImageURL = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Track%20icons%204x3/Austria%20carbon.png.transform/4col-retina/image.png",
                                    DataCursa = 10.07,
                                    CategorieCircuit = Enums.CategorieCircuit.Pista,
                                    TaraId = 13,
                                    Pret = 30.00
                                },
                                new Cursa()
                                {
                                    NumeCursa = "FORMULA 1 LENOVO GRAND PRIX DE FRANCE 2022",
                                    Descriere = "Verstappen wins from Hamilton and Russell after disaster for Leclerc",
                                    ImageURL = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Track%20icons%204x3/France%20carbon.png.transform/4col-retina/image.png",
                                    DataCursa = 24.07,
                                    CategorieCircuit = Enums.CategorieCircuit.Pista,
                                    TaraId = 14,
                                    Pret = 30.00
                                },
                                new Cursa()
                                {
                                    NumeCursa = "FORMULA 1 ARAMCO MAGYAR NAGYDÍJ 2022",
                                    Descriere = "Verstappen comes from P10 start to win from Hamilton in Budapest",
                                    ImageURL = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Track%20icons%204x3/Hungar%20carbon.png.transform/4col-retina/image.png",
                                    DataCursa = 31.07,
                                    CategorieCircuit = Enums.CategorieCircuit.Pista,
                                    TaraId = 15,
                                    Pret = 30.00
                                },
                                    new Cursa()
                                    {
                                        NumeCursa = "FORMULA 1 ROLEX BELGIAN GRAND PRIX 2022",
                                        Descriere = "Verstappen eases to Spa win as Red Bull clinch dominant 1-2",
                                        ImageURL = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Track%20icons%204x3/Belgium%20carbon.png.transform/4col-retina/image.png",
                                        DataCursa = 28.08,
                                        CategorieCircuit = Enums.CategorieCircuit.Pista,
                                    TaraId = 16,
                                    Pret = 30.00
                                    },
                                new Cursa()
                                {
                                    NumeCursa = "FORMULA 1 HEINEKEN DUTCH GRAND PRIX 2022",
                                    Descriere = "Verstappen beats Russell to victory in roller-coaster Dutch Grand Prix",
                                    ImageURL = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Track%20icons%204x3/Netherlands%20carbon.png.transform/4col-retina/image.png",
                                    DataCursa = 04.09,
                                    CategorieCircuit = Enums.CategorieCircuit.Pista,
                                    TaraId = 17,
                                    Pret = 30.00
                                },
                                new Cursa()
                                    {
                                    NumeCursa = "FORMULA 1 PIRELLI GRAN PREMIO D ITALIA 2022",
                                    Descriere = "Verstappen beats Leclerc to Monza win as Italian Grand Prix ends under Safety Car",
                                    ImageURL = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Track%20icons%204x3/Italy%20carbon.png.transform/4col-retina/image.png",
                                    DataCursa = 11.09,
                                    CategorieCircuit = Enums.CategorieCircuit.Pista,
                                    TaraId = 5,
                                    Pret = 30.00
                                   },
                                new Cursa()
                                {
                                    NumeCursa = "FORMULA 1 SINGAPORE AIRLINES SINGAPORE GRAND PRIX 2022",
                                    Descriere = "Peerless Perez holds off Leclerc for superb Red Bull win in Singapore",
                                    ImageURL = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Track%20icons%204x3/Singapor%20carbon.png.transform/4col-retina/image.png",
                                    DataCursa = 02.10,
                                    CategorieCircuit= Enums.CategorieCircuit.Stradal,
                                    TaraId = 18,
                                    Pret = 30.00
                                },
                                new Cursa()
                                {
                                    NumeCursa = "FORMULA 1 HONDA JAPANESE GRAND PRIX 2022",
                                    Descriere = "Verstappen seals title after winning rain-shortened Japanese Grand Prix",
                                    ImageURL = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Track%20icons%204x3/Japan%20carbon.png.transform/4col-retina/image.png",
                                    DataCursa = 09.10,
                                    CategorieCircuit = Enums.CategorieCircuit.Pista,
                                    TaraId = 19,
                                    Pret = 30.00
                                },
                                new Cursa()
                                {
                                    NumeCursa = "FORMULA 1 ARAMCO UNITED STATES GRAND PRIX 2022",
                                    Descriere = "Verstappen wins Austin thriller as Red Bull clinch constructors' crown",
                                    ImageURL = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Track%20icons%204x3/USA%20carbon.png.transform/4col-retina/image.png",
                                    DataCursa = 23.10,
                                    CategorieCircuit = Enums.CategorieCircuit.Pista,
                                    TaraId = 7,
                                    Pret = 30.00
                                },
                                new Cursa()
                                {
                                    NumeCursa = "FORMULA 1 HEINEKEN GRAN PREMIO DE LA CIUDAD DE MÉXICO 2022",
                                    Descriere = "Verstappen eases to record Mexico win from Hamilton and Perez",
                                    ImageURL = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Track%20icons%204x3/Mexico%20carbon.png.transform/4col-retina/image.png",
                                    DataCursa = 30.10,
                                    CategorieCircuit = Enums.CategorieCircuit.Pista,
                                    TaraId = 20,
                                    Pret = 30.00
                                },
                                new Cursa()
                                {
                                    NumeCursa = "FORMULA 1 HEINEKEN GRANDE PRÊMIO DE SÃO PAULO 2022",
                                    Descriere = "Mercedes one-two as Russell beats Hamilton for maiden win",
                                    ImageURL = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Track%20icons%204x3/Brazil%20carbon.png.transform/4col-retina/image.png",
                                    DataCursa = 13.11,
                                    CategorieCircuit = Enums.CategorieCircuit.Pista,
                                    TaraId = 21,
                                    Pret = 30.00
                                },
                                new Cursa()
                                {
                                    NumeCursa = "FORMULA 1 ETIHAD AIRWAYS ABU DHABI GRAND PRIX 2022",
                                    Descriere = "Verstappen wins as Leclerc pips Perez for second in Abu Dhabi",
                                    ImageURL = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Track%20icons%204x3/Abu%20Dhab%20carbon.png.transform/4col-retina/image.png",
                                    DataCursa = 20.11,
                                    CategorieCircuit = Enums.CategorieCircuit.Pista,
                                    TaraId = 22,
                                    Pret = 30.00
                                }



                            });
                            context.SaveChanges();
                            //Piloti si Cursa
                            if (!context.Pilotii_Cursaa.Any())
                            { 

                                context.Pilotii_Cursaa.AddRange(new List<Piloti_Cursa>()
                                    {

                                    new Piloti_Cursa()
                                    {
                                        CursaId = 1,
                                        PilotiId = 1
                                       
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 2,
                                    CursaId = 1
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 5,
                                    CursaId = 1
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 3,
                                    CursaId = 2
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 1,
                                    CursaId = 2
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 2,
                                    CursaId = 2
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 1,
                                    CursaId = 3
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 4,
                                    CursaId = 3
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 6,
                                    CursaId = 3
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 3,
                                    CursaId = 4
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 4,
                                    CursaId = 4
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 7,
                                    CursaId = 4
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 3,
                                    CursaId = 5
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 1,
                                    CursaId = 5
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 2,
                                    CursaId = 5
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 3,
                                    CursaId = 6
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 4,
                                    CursaId = 6
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 6,
                                    CursaId = 6
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 4,
                                    CursaId = 7
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 1,
                                    CursaId = 7
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 3,
                                    CursaId = 7
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 3,
                                    CursaId = 8
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 4,
                                    CursaId = 8
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 6,
                                    CursaId = 8
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 3,
                                    CursaId = 9
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 2,
                                    CursaId = 9
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 5,
                                    CursaId = 9
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 2,
                                    CursaId = 10
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 4,
                                    CursaId = 10
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 5,
                                    CursaId = 10
                                    },new Piloti_Cursa()
                                    {
                                    PilotiId = 3,
                                    CursaId = 9
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 2,
                                    CursaId = 9
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 1,
                                    CursaId = 11
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 3,
                                    CursaId = 11
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 5,
                                    CursaId = 11
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 3,
                                    CursaId = 12
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 5,
                                    CursaId = 12
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 6,
                                    CursaId = 12
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 3,
                                    CursaId = 13
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 5,
                                    CursaId = 13
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 6,
                                    CursaId = 13
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 3,
                                    CursaId = 14
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 4,
                                    CursaId = 14
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 2,
                                    CursaId = 14
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 3,
                                    CursaId = 15
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 6,
                                    CursaId = 15
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 1,
                                    CursaId = 15
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 3,
                                    CursaId = 16
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 1,
                                    CursaId = 16
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 6,
                                    CursaId = 16
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 4,
                                    CursaId = 17
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 1,
                                    CursaId = 17
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 2,
                                    CursaId = 17
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 3,
                                    CursaId = 18
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 4,
                                    CursaId = 18
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 1,
                                    CursaId = 18
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 3,
                                    CursaId = 19
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 5,
                                    CursaId = 19
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 1,
                                    CursaId = 19
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 3,
                                    CursaId = 20
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 5,
                                    CursaId = 20
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 4,
                                    CursaId = 20
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 6,
                                    CursaId = 21
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 5,
                                    CursaId = 21
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 2,
                                    CursaId = 21
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 3,
                                    CursaId = 22
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 1,
                                    CursaId = 22
                                    },
                                    new Piloti_Cursa()
                                    {
                                    PilotiId = 4,
                                    CursaId = 22
                                    }
                               });
                            }
                            context.SaveChanges();
                        }
                    }
                }
            }
        }
    }
}


