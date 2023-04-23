﻿using FA.BookStore.Core.Common;
using FA.JustBlog.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace FA.JustBlog.Core.DataContext
{
    public static class JustBlogInitializer
    {
        public static void SeedData(this ModelBuilder builder)
        {
            SeoUrlHepler seoUrlHepler = new SeoUrlHepler();
            builder.Entity<Categories>().HasData(
                new Categories
                {
                    CategoryId = 1,
                    CategoryName = "World",
                    Description = "The latest information of countries in the world or information of a global nature, having great influence on countries and ethnic groups",
                    UrlSlug = seoUrlHepler.ToUrlSlug("World"),
                },
                new Categories
                {
                    CategoryId = 2,
                    CategoryName = "Business",
                    Description = "Revolves around issues of Aerospace & Defense Autos & Transportation Energy Environment Finance Healthcare & Pharmaceuticals Media & Telecom Retail & Consumer Sustainable Business Charged Future of Health Future of Money Take Five Reuters Impact World at Work",
                    UrlSlug = seoUrlHepler.ToUrlSlug("Business"),

                },
                new Categories
                {
                    CategoryId = 3,
                    CategoryName = "Markets",
                    Description = "Asian Markets Carbon Markets Commodities Currencies Deals Emerging Markets European Markets Funds Global Market Data Rates & Bonds Stocks U.S. Markets Wealth Macro Matters",
                    UrlSlug = seoUrlHepler.ToUrlSlug("Markets"),
                },
                new Categories
                {
                    CategoryId = 4,
                    CategoryName = "Legal",
                    Description = "Hot topics related to the legal industry, lawsuits between countries, government information or transactions",
                    UrlSlug = seoUrlHepler.ToUrlSlug("Legal"),
                },
                new Categories
                {
                    CategoryId = 5,
                    CategoryName = "Technology",
                    Description = "the latest technology news, covering all things new technology, hardware as well as software, technological revolutions",
                    UrlSlug = seoUrlHepler.ToUrlSlug("Technology"),
                },
                new Categories
                {
                    CategoryId = 6,
                    CategoryName = "Sport",
                    Description = "Latest sports news, famous players, upcoming and upcoming major tournaments",
                    UrlSlug = seoUrlHepler.ToUrlSlug("Sport"),
                }
            );

            builder.Entity<Posts>().HasData(
                new Posts
                {
                    PostId = 1,
                    Title = "Big U.S. intelligence leak was by gun enthusiast in 20s, Washington Post reports",
                    ShortDescription = "April 12 (Reuters) - The person who leaked U.S. classified documents prompting a national security investigation is a gun enthusiast in his 20s who worked on a military base, the Washington Post reported on Wednesday, citing fellow members of an online chat group.",
                    PostContent = "The person shared classified information to a group on the instant messaging platform Discord of about two dozen men and young boys who shared a \"mutual love of guns, military gear and God,\" the Post said. The Post based its report, which did not name the person, on interviews with two members of the Discord chat group.\r\n\r\nReuters was unable to verify details of the report.\r\n\r\nDiscord said in a statement earlier on Wednesday that it was cooperating with law enforcement.  The Department of Defense and the Department of Justice did not immediately respond to a Reuters request for comment.\r\n\r\nThe Department of Justice opened a formal criminal probe last week after the matter was referred by the Pentagon, which is assessing the damage done by what may be the most damaging release of classified U.S. information in years. The person went by the handle OG, slang for Original Gangster, or an old school traditionalist. The person was described by one of the Post's sources as being in his early to mid-20s, and was looked up to by members of the group.\r\n\r\n\"He's fit. He's strong. He's armed. He's trained. Just about everything you can expect out of some sort of crazy movie,\" said one member of the chat group, who was under 18 and spoke on the condition of anonymity with the permission of his mother, the Post reported.\r\n\r\nIn what appears to be the gravest leak of U.S. secrets in years, pictures of sensitive documents were posed on Discord and other platforms including the online messaging board 4Chan, the encrypted Telegram global messaging app, and Twitter.\r\n\r\nU.S. national security agencies and the Justice Department are investigating the release to assess the damage to national security and relations with allies and other countries, including Ukraine. ",
                    UrlSlug = seoUrlHepler.ToUrlSlug("Big U.S. intelligence leak was by gun enthusiast in 20s, Washington Post reports"),
                    Published = true,
                    PostOn = DateTime.Parse("2023-03-14"),
                    Modified = DateTime.Now,
                    CategoryId = 1,
                    ViewCount = 2000,
                    RateCount = 2000,
                    TotalRate = 5000,
                    Rate = 5000 / 2000,
                },
                new Posts
                {
                    PostId = 2,
                    Title = "North Korea launches new type of ballistic missile, South says",
                    ShortDescription = "SEOUL/TOKYO, April 13 (Reuters) - North Korea fired a new model of long-range ballistic missile on Thursday, South Korea said, triggering a scare in northern Japan where residents were told to take cover, though there turned out to be no danger.",
                    PostContent = "A South Korean military official said the missile appeared to have been a new weapon displayed at recent North Korean military parades, and possibly used solid fuel.\r\n\r\nNorth Korea has been working to build more solid-fuel missiles, which are easier to store and transport, and can be launched with almost no warning or preparation time. The missile flew about 1,000 km (620 miles), South Korea's military said, calling it a \"grave provocation\". The official said the missile's maximum altitude was lower than 6,000 km, the apogee of some of last year's record-breaking tests.\r\n\r\n\"So far we assess that they fired a new type of ballistic missile with an intermediate or intercontinental range,\" the official said. \"We're still analysing details like the trajectory, altitude and range, with the possibility that it carried a solid-fuel propellant.\" 4 minute readApril 13, 20236:04 PM GMT+7Last Updated 2 hours ago\r\nNorth Korea launches new type of ballistic missile, South says\r\nReuters\r\nSEOUL/TOKYO, April 13 (Reuters) - North Korea fired a new model of long-range ballistic missile on Thursday, South Korea said, triggering a scare in northern Japan where residents were told to take cover, though there turned out to be no danger.\r\n\r\nA South Korean military official said the missile appeared to have been a new weapon displayed at recent North Korean military parades, and possibly used solid fuel.\r\n\r\nNorth Korea has been working to build more solid-fuel missiles, which are easier to store and transport, and can be launched with almost no warning or preparation time.\r\n\r\nAdvertisement · Scroll to continue\r\nThe missile flew about 1,000 km (620 miles), South Korea's military said, calling it a \"grave provocation\". The official said the missile's maximum altitude was lower than 6,000 km, the apogee of some of last year's record-breaking tests.\r\n\r\n\"So far we assess that they fired a new type of ballistic missile with an intermediate or intercontinental range,\" the official said. \"We're still analysing details like the trajectory, altitude and range, with the possibility that it carried a solid-fuel propellant.\"\r\n\r\nAdvertisement · Scroll to continue\r\nThe South Korean military said it was on high alert and coordinating closely with its main ally, the United States, which \"strongly condemned\" what the White House said in a statement was a long-range ballistic missile test.\r\n\r\nFollowing the missile launch, the Japanese and U.S. air forces conducted drills over the Sea of Japan \"as the security environment surrounding Japan is becoming more and more severe,\" the Japanese defence ministry said. While North Korea has tested short-range solid-fuel missiles, it has not tested a long-range missile of that type, said Bruce Bennett, a senior defence analyst at the U.S.-based RAND Corporation.\r\n\r\nKim Dong-yup, a former South Korean navy officer who teaches at Kyungnam University's Far East Institute, said the new system might have been an intercontinental ballistic missile that was unveiled at a February military parade, and powered by a solid-fuel engine tested in December. 4 minute readApril 13, 20236:04 PM GMT+7Last Updated 2 hours ago\r\nNorth Korea launches new type of ballistic missile, South says\r\nReuters\r\nSEOUL/TOKYO, April 13 (Reuters) - North Korea fired a new model of long-range ballistic missile on Thursday, South Korea said, triggering a scare in northern Japan where residents were told to take cover, though there turned out to be no danger.\r\n\r\nA South Korean military official said the missile appeared to have been a new weapon displayed at recent North Korean military parades, and possibly used solid fuel.\r\n\r\nNorth Korea has been working to build more solid-fuel missiles, which are easier to store and transport, and can be launched with almost no warning or preparation time.\r\n\r\nAdvertisement · Scroll to continue\r\nThe missile flew about 1,000 km (620 miles), South Korea's military said, calling it a \"grave provocation\". The official said the missile's maximum altitude was lower than 6,000 km, the apogee of some of last year's record-breaking tests.\r\n\r\n\"So far we assess that they fired a new type of ballistic missile with an intermediate or intercontinental range,\" the official said. \"We're still analysing details like the trajectory, altitude and range, with the possibility that it carried a solid-fuel propellant.\"\r\n\r\nAdvertisement · Scroll to continue\r\nThe South Korean military said it was on high alert and coordinating closely with its main ally, the United States, which \"strongly condemned\" what the White House said in a statement was a long-range ballistic missile test.\r\n\r\nFollowing the missile launch, the Japanese and U.S. air forces conducted drills over the Sea of Japan \"as the security environment surrounding Japan is becoming more and more severe,\" the Japanese defence ministry said.\r\n\r\nReuters Graphics Reuters Graphics\r\nReuters Graphics Reuters Graphics\r\nWhile North Korea has tested short-range solid-fuel missiles, it has not tested a long-range missile of that type, said Bruce Bennett, a senior defence analyst at the U.S.-based RAND Corporation.\r\n\r\nKim Dong-yup, a former South Korean navy officer who teaches at Kyungnam University's Far East Institute, said the new system might have been an intercontinental ballistic missile that was unveiled at a February military parade, and powered by a solid-fuel engine tested in December.\r\n\r\nAdvertisement · Scroll to continue\r\nThe missile was fired at 7:23 a.m. (2223 GMT on Wednesday) from near Pyongyang, the South's military said. Japan's coast guard said it had landed by 8:19 a.m.\r\n\r\nIt could have been launched from an international airport close to North Korea's capital, a major site for test-firing large missiles since 2017. The nuclear envoys of allies South Korea, the U.S. and Japan spoke and condemned the launch, saying North Korea had constantly threatened regional peace with \"unprecedented levels of provocations and menacing words\", South Korea's foreign ministry said.\r\n\r\nJapan called a National Security Council meeting in response to the launch. Its defence minister, Yasukazu Hamada, said the missile appeared to have been fired eastward at a high angle and it did not fall in Japanese territory.\r\n\r\nJapan's coast guard said the projectile had fallen in the sea to the east of North Korea. Hamada said he could not confirm whether the missile had flown over Japan's exclusive economic zone.\r\n\r\nAuthorities retracted the alert for Hokkaido island in northern Japan when they determined that the missile would not fall nearby.\r\n\r\nSchools in Hokkaido delayed their opening times and some train services were suspended, Japanese broadcaster NHK reported.\r\n\r\nA student there said the alert caused momentary alarm at a train station.\r\n\r\n\"For a second in the train there was panic, but a station worker said to calm down, and people did,\" a student told NHK.\r\n\r\nThe launch came days after North Korean leader Kim Jong Un called for strengthening war deterrence in a \"more practical and offensive\" manner to counter what North Korea called moves of aggression by the United States.\r\n\r\nWhile condemning the latest in a string of North Korean missile tests, the United States renewed its offer to open talks.\r\n\r\n\"The door has not closed on diplomacy, but Pyongyang must immediately cease its destabilising actions and instead choose diplomatic engagement,\" U.S. National Security Council spokesperson Adrienne Watson said in a statement.\r\n\r\nNorth Korea has criticised recent joint military exercises between U.S. and South Korean forces as escalating tensions, stepping up its weapons tests in recent months. ",
                    UrlSlug = seoUrlHepler.ToUrlSlug("North Korea launches new type of ballistic missile, South says"),
                    Published = true,
                    PostOn = DateTime.Parse("2023-02-14"),
                    Modified = DateTime.Now,
                    CategoryId = 1,
                    ViewCount = 1000,
                    RateCount = 250,
                    TotalRate = 500,
                    Rate = 500 / 250
                },
                new Posts
                {
                    PostId = 3,
                    Title = "US manufacturing boom has a real estate problem",
                    ShortDescription = "U.S. President Joe Biden attends the groundbreaking of the new Intel semiconductor manufacturing facility in New Albany, Ohio, U.S., September 9, 2022. REUTERS/Joshua Roberts",
                    PostContent = "April 13 (Reuters) - Volkswagen's off-road brand Scout Motors studied 74 different parcels of land across the U.S. last summer as it hunted for a place to build a $2 billion assembly plant.\r\n\r\nIt quickly eliminated almost all of them. In one case, they learned it would take six years to build a needed rail link. Others lacked access to clean power - crucial for a project for \"green\" electric vehicles. Some did not offer enough nearby skilled labor. \"We were hitting a deadline,\" said Scott Keogh, Scout's CEO, so they settled for a parcel in South Carolina that has all their desired features but is a bit smaller than they initially wanted - 1,600 instead of 2,000 acres.\r\n\r\nScout's scramble highlights a challenge facing dozens of global manufacturers. Fueled by a combination of hefty government incentives, a transition to new transportation and energy technologies, and national security concerns about relying on distant suppliers, especially in China, there's a factory-building boom taking place across the U.S.\r\n\r\nBut all that new construction has a real estate problem. More specifically, a \"megasite\" problem. While the U.S. has plentiful land, there are not that many places to quickly plunk a billion-dollar-plus factory. The factory renaissance could soon hit a barrier because of the scarcity of ready-to-go megasites, according to 25 economic development groups, state and local officials, utilities, and companies interviewed by Reuters.\r\n\r\nThat would be a problem for the Biden administration, which has pushed through legislation to fuel the developments. Corporations have announced dozens of projects since the passage of the Inflation Reduction Act and the CHIPS Act last year.\r\n\r\nA White House official said it was a \"high-class problem\" to have, adding: \"Folks are finding places to build. I don't think I've heard of one company abandoning plans to go forward because they're not able to find a site.\" There’s no single definition for a megasite, but it generally refers to a very large plot — one common threshold is 1,000 acres — tied to transport, low-cost and preferably renewable energy, and a nearby supply of skilled labor. Local economic development agencies and states have long cultivated big industrial developments by assembling land and installing utilities in the hope of luring the next big auto assembly or steel plant with the promise of fast-track building.\r\n\r\nSpeed is often key. When electric vehicle maker Rivian Automotive Inc. was hunting for a place to build a $5 billion plant, it considered a spot just outside Fort Worth, Texas.\r\n\r\nBut the EV-maker \"had some pretty aggressive timelines as far as when they needed certain elements of the transportation infrastructure in place,\" said Robert Sturns, director of the Fort Worth Economic Development Department. Fort Worth could not meet those, and the project jumped to Georgia in late 2021.\r\n\r\nThe requirements on megasites can be very specific. Intel Corp's $20 billion semiconductor plant going up in Ohio could not be situated too close to a rail line, since passing trains can create unacceptable vibrations, according to the company.\r\n\r\nEven smaller factories can find it difficult to build quickly in this environment.\r\n\r\nCubicPV, which makes silicon wafers used in solar panels, launched a nationwide search for a 100-to-130-acre site immediately after the IRA passed last August. They have a tight time frame, said Todd Templeton, the company's chief commercial officer, since IRA tax incentives start to phase out at the end of this decade.\r\n\r\nThey studied hundreds of sites but constantly hit roadblocks. Some locations said it would take two or three years just to get utilities installed, said Templeton. They are choosing from two good possibilities and are aiming to have the plant open by 2025.\r\n\r\nOne site selection executive, Gregg Wassmansdorf, a senior managing director of global strategy consulting with Newmark Group Inc., estimates fewer than two dozen true megasites are still available across the country at widely varying stages of development.\r\n\r\n\"Every company, of course, wants shovel-ready megasites,\" said Christopher Chung, chief executive of the Economic Development Partnership of North Carolina. \"But those are more or less pretty picked over with a couple of exceptions here or there.\" Didi Caldwell, president of consultancy firm Global Location Strategies in Greenville, South Carolina, uses a database from fDi Markets, a London-based firm that tracks major cross-border investments worldwide, to gauge how fast demand for megasites has grown in the U.S.\r\n\r\nAccording to that source, she said, there were 20 industrial projects with investments over $1 billion and a promise of creating at least 1,000 jobs announced last year in the U.S. - up from 15 the year before, and only eight the year before that.\r\n\r\nIn the decade and a half before the recent spike, the annual average was just over five and many years saw just three or four large projects announced.\r\n\r\nOne major constraint, particularly for energy-hungry factories such as battery plants, is the need for large amounts of electrical power.\r\n\r\n\"Some of these projects require hundreds of megawatts,\" said Caldwell. \"At the same time, we're shutting a lot of coal plants.\"\r\n\r\nWhile the U.S. is investing heavily in building green power sources, those projects also face delays. A report by Lawrence Berkeley National Laboratory found that a typical project built in 2022 took five years from the initial request to interconnect it with the electrical grid to commercial operations, up from three years in 2015.\r\n\r\nThe cost and difficulty of building new long-distance transmission lines has also soared in recent years, said Rob Gramlich, president of Grid Strategies LLC, an engineering and economic analysis firm focused on the power industry.\r\n\r\nThere's a rush to prepare more megasites. Michigan just created four. The governors of South Carolina, Virginia and North Carolina have each proposed to spend hundreds of millions of dollars on readying industrial sites in the coming years. Illinois this year will allocate $40 million in grants to prepare existing sites for companies seeking to move quickly.\r\n\r\nBut creating new megasites is inherently difficult. Environmental regulations often limit developments, local communities sometimes oppose them, and the sheer scale of the projects often require just the right mix of conditions to make it feasible.\r\n\r\nTo be sure, companies want more megasites for pocketbook reasons.\r\n\r\n\"The reason they would like more megasites, of course, is that then they could compete for better pricing\" when they have more options to choose from, said Mike Tracy, principal of the Agile Group, which advises companies like automakers.\r\n\r\nThere are also the intangibles.\r\n\r\nThe VW Scout plant, for instance, is situated in clear view of a major interstate highway connecting South Carolina's coastal regions to the upper Midwest. That means putting the Scout name, being revived by VW after four decades of dormancy, in sight of tens of thousands of passing motorists a day.\r\n\r\n\"We have a lot of people who are coming from the north or from the Midwest down that highway that would drive right by that facility as they go to the beaches of South Carolina and Georgia and Florida,\" said Harry Lightsey III, South Carolina’s secretary of commerce. \"That was all important.\" ",
                    UrlSlug = seoUrlHepler.ToUrlSlug("US manufacturing boom has a real estate problem"),
                    Published = true,
                    PostOn = DateTime.Parse("2022-09-26"),
                    Modified = DateTime.Now,
                    CategoryId = 2,
                    ViewCount = 5000,
                    RateCount = 800,
                    TotalRate = 2000,
                    Rate = 2000 / 800
                },
                new Posts
                {
                    PostId = 4,
                    Title = "Bankrupt crypto exchange FTX has recovered $7.3 billion in assets",
                    ShortDescription = "FTX logo is seen in this illustration taken March 31, 2023. REUTERS/Dado Ruvic/Illustration",
                    PostContent = "April 12 (Reuters) - Bankrupt crypto exchange FTX has recovered over $7.3 billion in cash and liquid crypto assets, an increase of more than $800 million since January, the company's attorney said on Wednesday at a U.S. bankruptcy court hearing in Delaware.\r\n\r\nFTX attorney Andy Dietderich said the company is starting to think about its future after months of effort devoted to collecting resources and figuring out what went wrong under the leadership of indicted ex-founder Sam Bankman-Fried. Bankman-Fried has pleaded not guilty. \"The situation has stabilized, and the dumpster fire is out,\" Dietderich said.\r\n\r\nFTX has benefited from a recent rise in crypto prices, Dietderich said. Its total recovery would be valued at $6.2 billion based on crypto prices from November 2022, when it filed for bankruptcy after traders pulled $6 billion from the platform in three days and rival exchange Binance abandoned a rescue deal.\r\n\r\nFTX's new CEO John Ray has detailed improper fund transfers and poor accounting at the collapsed crypto exchange, describing it as a \"complete failure\" of controls. As it looks to the future, FTX is negotiating with stakeholders about options for restarting its crypto exchange, and it may make a decision on that in the current quarter, Dietderich said.\r\n\r\nHe offered few details on what a reboot might mean for FTX customers whose crypto deposits have been locked up during the bankruptcy case.\r\n\r\nSo far, FTX customers in Japan have been the only ones able to withdraw any funds so far, because of that country's relatively strong crypto regulations, Dietderich said.\r\n\r\nFTX would need significant capital to restart its crypto exchange, because the existing customer interface had little connection to the movement of money behind the scenes, the lawyer said.\r\n\r\n\"The app worked beautifully, but in truth it was a facade,\" Dietderich said.\r\n\r\nIt is not clear whether FTX should use its own funds to re-start the exchange, rather than using the money to repay customers, Dietderich said. Restarting the exchange might require outside funding or a sale of the exchange's assets. FTX is also working on a preliminary Chapter 11 plan that would offer the company a path out of bankruptcy, Dietderich said.\r\n\r\nFTX intends to file that plan by July, but it acknowledged that many details would have to be worked out as creditors fight for their share of the company's assets. FTX does not expect any Chapter 11 plan to be approved before the second quarter of 2024.\r\n\r\nBankman-Fried and several company insiders have been indicted on fraud charges for their role in the company's collapse. In contrast to Bankman-Fried's not guilty plea, the former members of his inner circle have pleaded guilty and agreed to cooperate with prosecutors.",
                    UrlSlug = seoUrlHepler.ToUrlSlug("Bankrupt crypto exchange FTX has recovered $7.3 billion in assets"),
                    Published = true,
                    PostOn = DateTime.Parse("2023-02-01"),
                    Modified = DateTime.Now,
                    CategoryId = 2,
                    ViewCount = 750,
                    RateCount = 100,
                    TotalRate = 300,
                    Rate = 300 / 100
                },
                new Posts
                {
                    PostId = 5,
                    Title = "China's exports rise unexpectedly, but economists warn of weakness ahead",
                    ShortDescription = "An aerial view shows containers and cargo vessels at the Qingdao port in Shandong province, China May 9, 2022. Picture taken with a drone. China Daily via REUTERS",
                    PostContent = "BEIJING, April 13 (Reuters) - China's exports unexpectedly surged in March, with officials flagging rising demand for electric vehicles, but analysts cautioned the improvement partly reflects suppliers catching up with unfulfilled orders after last year's COVID-19 disruptions.\r\n\r\nExports in March shot up 14.8% from a year ago, snapping five straight months of declines and stunning economists who predicted a 7.0% fall in a Reuters poll. But analysts say the jump was more likely related to exporters rushing to fulfil a backlog of orders that had been disrupted by the pandemic in past months, and warned the global demand outlook remained subdued.\r\n\r\n\"The wave of COVID outbreaks in December and January likely depleted factories' inventories. Now that factories are running at full capacity, they caught up the cumulated orders from the past,\" said Zhiwei Zhang, chief economist at Pinpoint Asset Management.\"\r\n\r\n\"The strong export growth is unlikely to sustain given the weak global macro outlook,\" he added. 3 minute readApril 13, 20234:00 PM GMT+7Last Updated 4 hours ago\r\nChina's exports rise unexpectedly, but economists warn of weakness ahead\r\nBy Joe Cash and Ellen Zhang\r\nContainers and cargo vessels at the Qingdao port\r\nAn aerial view shows containers and cargo vessels at the Qingdao port in Shandong province, China May 9, 2022. Picture taken with a drone. China Daily via REUTERS\r\nBEIJING, April 13 (Reuters) - China's exports unexpectedly surged in March, with officials flagging rising demand for electric vehicles, but analysts cautioned the improvement partly reflects suppliers catching up with unfulfilled orders after last year's COVID-19 disruptions.\r\n\r\nExports in March shot up 14.8% from a year ago, snapping five straight months of declines and stunning economists who predicted a 7.0% fall in a Reuters poll.\r\n\r\nAdvertisement · Scroll to continue\r\nBut analysts say the jump was more likely related to exporters rushing to fulfil a backlog of orders that had been disrupted by the pandemic in past months, and warned the global demand outlook remained subdued.\r\n\r\n\"The wave of COVID outbreaks in December and January likely depleted factories' inventories. Now that factories are running at full capacity, they caught up the cumulated orders from the past,\" said Zhiwei Zhang, chief economist at Pinpoint Asset Management.\"\r\n\r\n\"The strong export growth is unlikely to sustain given the weak global macro outlook,\" he added.\r\n\r\nAdvertisement · Scroll to continue\r\nMeanwhile, imports fell less than expected, with economists pointing to an acceleration in the purchase of agricultural products, especially soybeans, as providing some support.\r\n\r\nImports dropped just 1.4%, smaller than the 5.0% decline forecast and a 10.2% contraction in the previous two months. Increases in crude oil, iron ore and soybeans imports in the month were offset by a decline in copper imports. Financial markets took little cheer from the upbeat export data as investors remained wary about the outlook, although the Australian dollar, seen as a proxy for Chinese demand for commodities, rose slightly.\r\n\r\nLv Daliang, spokesperson of the General Administration of Customs, attributed the upside surprise to strength in demand for electric vehicles, solar products and lithium batteries.\r\n\r\nHowever, he warned conditions could worsen going forward. \"The external environment is still severe and complicated at present,\" Lv told reporters in Beijing on Thursday. \"Sluggish external demand and geopolitical factors will bring greater challenges to China's trade development,\" he added.\r\n\r\nChina's strong performance contrasts with that of other Asian exporters, such as South Korea and Vietnam, which have both seen exports decline in the first few months of 2023, contributing to doubts that it can be sustained.\r\n\r\n\"We aren’t convinced that this rebound will be sustained given the still gloomy outlook for foreign demand,\" Capital Economics analysts said in a note.\r\n\r\n\"We expect most developed economies to slip into recession this year and think that the downturn in Chinese exports still has some way to run before it reaches a bottom later this year.\"\r\n\r\nFactory surveys showed export orders falling in March, a contrast to more upbeat readings for the services sector, which has benefited from China's reopening.\r\n\r\nChina's newly appointed premier Li Qiang told a cabinet meeting last week that officials should \"try every method\" to grow trade with developed economies and push companies to further explore emerging market economies, such as those of Southeast Asia.\r\n\r\nBeijing has set a growth target of around 5% for gross domestic product (GDP) this year, after severe pandemic controls last year knocked the economy to one of its slowest rates in decades. GDP rose only 3% last year.",
                    UrlSlug = seoUrlHepler.ToUrlSlug("China's exports rise unexpectedly, but economists warn of weakness ahead"),
                    Published = true,
                    PostOn = DateTime.Parse("2022-11-11"),
                    Modified = DateTime.Now,
                    CategoryId = 3,
                    ViewCount = 200,
                    RateCount = 20,
                    TotalRate = 50,
                    Rate = 50 / 20
                },
                new Posts
                {
                    PostId = 6,
                    Title = "Marketmind: Dollar skids, China revs",
                    ShortDescription = "Traders work on the floor of the New York Stock Exchange (NYSE) in New York City, U.S., April 10, 2023. REUTERS/Brendan McDermid",
                    PostContent = "A look at the day ahead in U.S. and global markets from Mike Dolan\r\n\r\nRelief at the pace of U.S. disinflation hasn't stopped markets betting on one final Federal Reserve rate hike next month, but an ebbing dollar already assumes it will be the last.\r\n\r\nThe dollar's DXY index - the Swiss franc hit its strongest level in more than two years.\r\n\r\nBut it's the lowest U.S. headline inflation rate in almost two years that's dominated thinking, with the surprisingly large drop to 5.0% last month meaning the 'real' inflation-adjusted Fed policy rate will turn positive for the first time in three years if the central bank delivers one last rate rise in May. Even though some policymakers wobbled about further hikes at the March meeting, due largely to the month's banking stress, and some talked of 'mild recession' ahead, minutes of the meeting suggest there was enough confidence about containing last month's bank blowup to nudge rates above 5%.\r\n\r\nTaking in all the information, futures markets still show a near 75% chance of another quarter point rate rise to the 5.0-5.25% range in May, but more than 60 basis points of cuts from there to yearend.\r\n\r\nTwo-year Treasury yields were stuck at 4%, with producer price inflation and weekly jobless up next on Thursday's data calendar. Wall St stock futures were back in positive territory. Signs that a global recession may indeed be avoided while inflation ebbs has many investors once again pondering the possibility that the Fed may indeed pull of a rare 'soft landing' for the economy.\r\n\r\nRemoving his forecast for a June rate hike to follow next month's move, Goldman Sachs chief economist Jan Hatzius still thinks a soft landing can be achieved.\r\n\r\nCertainly Thursday's news of a surprising surge in China's exports last month eased concerns about world demand and some fears about the strength of the recovery in the world's second largest economy.\r\n\r\nAlong with benign world growth forecasts from the International Monetary Fund this week, equity investors remain reluctant to throw in the towel - even if they are now focussed on defensive stocks, quality mega-caps and 'value' plays in relatively cheap European and Japanese indices. As a case in point, the bluest of blue chip European stock indices, the STOXX50 (.STOXX50), hit its highest in 22 years on Wednesday and Warren Buffett doubled down on his bet on Japan's big brokerages.\r\n\r\nThat taste for European blue chips was underlined on Thursday as LVMH LVMH.PA, the world's largest luxury company, gained 4.6% after reporting a 17% jump in first-quarter sales that breezed past estimates as business in China rebounded.\r\n\r\nEuropean markets were further pepped by reports the European Central Bank was minded to downsize its rate hikes to a quarter point in May after six successive half point moves.\r\n\r\nOne potential negative fallout from the relatively upbeat U.S. and China growth and inflation pictures is this week's pop in oil - although year-on-year Brent crude prices are still falling at whopping 20% pace and should continue to weigh on annual inflation rates through April.\r\n\r\nKey developments that may provide direction to U.S. markets later on Thursday:\r\n\r\n* U.S. March producer price inflation, weekly jobless claims\r\n\r\n* Bundesbank President Joachim Nagel, Bank of Canada governor Tiff Macklem and Bank of England chief economist Huw Pill all speak\r\n\r\n* U.S. President Joe Biden in Ireland\r\n\r\n* U.S. Treasury auctions 30-year bonds ",
                    UrlSlug = seoUrlHepler.ToUrlSlug("Marketmind: Dollar skids, China revs"),
                    Published = false,
                    PostOn = DateTime.Parse("2022-07-22"),
                    Modified = DateTime.Now,
                    CategoryId = 3,
                    ViewCount = 12000,
                    RateCount = 1800,
                    TotalRate = 4000,
                    Rate = 4000 / 1800
                },
                new Posts
                {
                    PostId = 7,
                    Title = "Can AI answer your money questions? We put chatbots to the test",
                    ShortDescription = "A smartphone with a displayed ChatGPT logo is placed on a computer motherboard in this illustration taken February 23, 2023. REUTERS/Dado Ruvic/Illustration/File Photo",
                    PostContent = "NEW YORK, April 13 (Reuters) - Face it, we could all use a little help with our money. So who better to ask for personal finance advice than a couple of the most powerful chatbots on the planet?\r\n\r\nBoth OpenAI’s ChatGPT and Google’s Bard are dominating headlines recently, for their generative capabilities and vast storehouses of information. Each has far more processing power than, say, any individual personal finance writer (ahem). That in mind, we asked our AI assistants-slash-overlords these classic personal finance questions:\r\n\r\nWhat is one great business idea?\r\n\r\nEntrepreneurs are always looking for the Next Big Thing. On this matter, ChatGPT was surprisingly specific: \"One idea could be to start a subscription-based meal delivery service that caters to customers with specific dietary needs or preferences, such as vegan, gluten-free, or low-carb diets.\" Bard does not seem to like limiting itself to one option, even when asked to do so – it prefers lists. It threw out a whole slew of ideas, including dog walking, translation, “website flipping\" and even working as a virtual assistant.\r\n\r\nWhat one town should I move to, to save the most money?\r\n\r\nWith the rise of remote work in the pandemic era, many Americans have considered relocating to lower-cost locales. ChatGPT singled out Fort Wayne, Indiana, and Knoxville, Tennessee, praising both for their affordability and growing job markets.\r\n\r\nBard also likes Fort Wayne, but added a few other contenders: Henderson, Nevada; Sioux Falls, South Dakota; Wichita, Kansas; and Oklahoma City.\r\n\r\nWhat one dividend stock is the most attractively valued?\r\n\r\nWhile stressing that as an AI language processor it “cannot provide personalized investment advice or predict stock performance,” ChatGPT praised telecommunications giant AT&T (T.N) for its cheap metrics. Its lower-than-average price-to-earnings ratio, plus its 7.1% dividend yield, caught the chatbot’s attention. Meanwhile, chatty Bard concurred with the choice of AT&T, but also added Verizon (VZ.N), Procter & Gamble (PG.N), 3M (MMM.N), and Johnson & Johnson (JNJ.N) to the mix as bargain stocks.\r\n\r\nWhat one growth stock is the most attractively valued?\r\n\r\nWhen ChatGPT crunched the numbers on this question, it produced a familiar name: Amazon (AMZN.O), praising the e-commerce giant for its attractive price-to-sales and price-to-book metrics after a challenging year.\r\n\r\nBard also mentioned Amazon, but tossed in Apple (AAPL.O), Tesla (TSLA.O), and (maybe not surprisingly) Google parent Alphabet (GOOGL.O), noting that price-to-earnings ratios for all of them were well below their five-year averages.\r\n\r\nGive me one idea of a growing career field?\r\n\r\nMany Americans seem to be switching careers these days – either of their own volition with the Great Resignation or forced because of layoffs. ChatGPT tells me to consider the field of data science and analytics, specifically roles like data analyst and machine learning engineer.\r\n\r\nBard is a little broader in its suggestions, nudging me to consider becoming a nurse practitioner, software developer, social media manager or even solar photovoltaic installer.\r\n\r\nWhat colleges give the most bang for the buck?\r\n\r\nSince my own teenager is off to college in the fall, I was particularly curious about this one. And ChatGPT did indeed have some answers: The University of North Carolina in Chapel Hill and Brigham Young University in Provo, Utah.\r\n\r\nBard had its own thoughts, though. It singled out the University of Washington, CUNY Brooklyn, Purdue, the University of Florida in Gainesville and Oklahoma State as offering an attractive combination of quality and value.\r\n\r\nWhat one vacation spot is the cheapest option for summer?\r\n\r\nBard was not very helpful here, suggesting bunking with friends or family or arranging a \"staycation,\" which was hardly inspiring. But ChatGPT did have specific ideas for an affordable summer trip: Great Smoky Mountains National Park, Myrtle Beach, South Carolina, and Austin, Texas.\r\n\r\nCan money buy happiness?\r\n\r\nI couldn’t leave our new AI friends without asking a deeper question about money and its role in our existence. ChatGPT admitted it can be a factor in a happy life: “Studies have shown that up to a certain point, increasing wealth can be associated with increased happiness, as it can provide access to basic needs such as food, shelter, and healthcare, as well as opportunities for education and experiences.”\r\n\r\nBut Bard was a little more declarative on the subject, that cash will not get us the ultimate satisfaction we are seeking.\r\n\r\n“Money cannot buy you happiness itself,” it told me. “Happiness is a state of mind that comes from within. It is not something that can be bought or sold.” ",
                    UrlSlug = seoUrlHepler.ToUrlSlug("Can AI answer your money questions? We put chatbots to the tes"),
                    Published = true,
                    PostOn = DateTime.Parse("2022-04-20"),
                    Modified = DateTime.Now,
                    CategoryId = 5,
                    ViewCount = 800,
                    RateCount = 30,
                    TotalRate = 100,
                    Rate = 100 / 30
                },
                new Posts
                {
                    PostId = 8,
                    Title = "Apple to use only recycled cobalt in batteries by 2025",
                    ShortDescription = "Signage is seen at the Apple Fifth Avenue store for the release of the Apple iPhone 14 range in Manhattan, New York City, U.S., September 16, 2022. REUTERS/Andrew Kelly",
                    PostContent = "April 13 (Reuters) - Apple Inc (AAPL.O) said on Thursday it would use only recycled cobalt in batteries by 2025 as a part of its efforts to make all its products carbon neutral by the end of the decade.\r\n\r\nMagnets in Apple devices will use recycled rare earth elements, and in-house designed printed circuit boards will use recycled tin soldering and gold plating, the company said.\r\n\r\nApple is pushing to become carbon neutral through its entire supply chain and the life cycle of every product by 2030. On Tuesday, it also doubled its financial commitment to a fund it had established two years ago to invest in projects that remove carbon from the atmosphere. read more In the past, several tech companies have been accused of being complicit in the death of children in the Democratic Republic of Congo (DRC) forced to mine cobalt, a critical material in the batteries used in most consumer electronics.\r\n\r\nMost cobalt is produced as a by-product of copper or nickel mining, but artisanal miners in southern Congo exploit deposits near the surface that are rich in cobalt.\r\n\r\nA quarter of all cobalt used in Apple products came from recycled material in 2022, up from 13% a year earlier, Apple said. It now sources over two-thirds of all aluminum, nearly three-quarters of all rare earths, and more than 95% of all tungsten in its products from recycled material. ",
                    UrlSlug = seoUrlHepler.ToUrlSlug("Apple to use only recycled cobalt in batteries by 2025"),
                    Published = false,
                    PostOn = DateTime.Parse("2022-06-30"),
                    Modified = DateTime.Now,
                    CategoryId = 5,
                    ViewCount = 3000,
                    RateCount = 700,
                    TotalRate = 1500,
                    Rate = 1500 / 700
                },
                new Posts
                {
                    PostId = 9,
                    Title = "Analysis: To convict Trump on hush money charges, prosecutors must get into his head",
                    ShortDescription = "April 5 (Reuters) - For prosecutors to win their unprecedented case against Donald Trump unveiled on Tuesday, they must meet the heavy burden of proving that the former U.S. president knowingly tried to cover up a crime by hiding a hush money payment.",
                    PostContent = "It's a question of intent, legal experts said.\r\n\r\nManhattan District Attorney Alvin Bragg said that Trump made false records in his family real estate company's books to conceal that he reimbursed his personal lawyer Michael Cohen for a $130,000 hush money payment before the 2016 election. The payment to porn star Stormy Daniels was part of a wider \"catch-and-kill\" scheme to suppress damaging news stories about Trump, prosecutors said. Prosecutors will need to go through a two-step process of proving that Trump intended to not only falsify business records but did so in furtherance of another crime.\r\n\r\n\"There's actually two levels of intent that have to be proven,\" said Anna Cominsky, a professor at New York Law School. \"First, they have to prove an intent to defraud by making a false business record. Then they have to prove an intent to defraud, including an intent to commit or conceal another crime.\"\r\n\r\nFalsification of business records on its own is a misdemeanor under New York law, but prosecutors elevated the charges to felonies by alleging they were tied to other crimes. The 34-count indictment does not list the other crimes, but Bragg told reporters Trump falsified records as part of a scheme to violate state and federal election laws, as well as state tax laws. Trump's lawyers have denied he falsified any records. They may also argue Trump's intent in paying Daniels was not to help his presidential campaign but to quash an unflattering story, which is not illegal.\r\n\r\nThe case marks the first time a former president has been criminally charged, and Trump's ongoing campaign to retake the presidency in 2024 has heaped additional scrutiny onto the case. Trump and his Republican allies claim the prosecution is politically motivated.\r\n\r\nTrump pleaded not guilty to the charges and denies having an affair with Daniels. His lawyers have said there were no false records entered into the Trump Organization's books, and that they will seek to get the charges dismissed before the case reaches trial.\r\n\r\nProving a defendant intended to commit a crime is a common challenge for prosecutors in white collar cases. Often, they use contemporaneous emails and text messages to show the defendant knew what they were doing was illegal. They also often rely on testimony from witnesses involved in or close to the scheme.\r\n\r\nBragg told reporters that electronic communication records backed up the case, although Trump himself has been widely reported not to have used text messages or emails until recently. A statement of facts accompanying the indictment cites meetings and phone calls with Cohen, Trump's former personal lawyer, indicating his testimony will be central to proving Trump's intent. Cohen, who testified twice before the grand jury, has said Trump directed him to make and disguise the payments. But he pleaded guilty to lying to Congress and violating election law with the Daniels payment. Trump's lawyers will use this to attack his credibility.\r\n\r\n\"You have to prove that Trump himself did that or caused that to be done. So you're going to have to believe the witnesses' accounts,\" said Sarah Krissoff, a former federal prosecutor and partner at Day Pitney. \"Here, they have some narrators, but the narrators have a lot of baggage.\"\r\n\r\nCohen said in a text message that the \"ongoing and continuous attacks\" on his credibility would have little impact on the case.\r\n\r\nProsecutors' statement of facts provides some hints as to how they might back up Cohen's testimony. It describes a meeting in Trump Tower shortly after Trump launched his presidential campaign in 2015 in which Trump, Cohen, and the chief executive of American Media Inc (AMI) discussed a plan to suppress negative news stories.\r\n\r\nDaniels in October 2016 sought to sell her story about her sexual encounter with Trump to AMI, which owns the National Enquirer tabloid. AMI then alerted Cohen, who negotiated the hush money deal with Daniels' lawyer.\r\n\r\nAMI's CEO, David Pecker, also appeared before the grand jury that indicted Trump. If he testifies at trial and corroborates Cohen's account, it could help prosecutors' case.\r\n\r\nThe statement of facts also references former Trump Organization chief financial officer Allen Weisselberg, who pleaded guilty to tax fraud and other crimes last year and testified against the Trump Organization, which was convicted of orchestrating a 15-year tax fraud scheme.\r\n\r\nWhile it is unclear if Weisselberg would turn on Trump, his testimony could help prosecutors corroborate their evidence.\r\n\r\nCohen and a lawyer for Pecker did not immediately respond to requests for comment Wednesday.\r\n\r\nProsecutors have the burden of proof, and Trump does not need to offer his own explanation of the payments to prevail. But some legal experts said the reasonable inferences point to Trump purposefully falsifying records in order to break other laws.\r\n\r\n\"To me, it's straightforward criminal law,\" said Bennett Gershman, a Pace University law professor and former prosecutor. \"You've got the act, you've got the consequences and you've got the culpable mental state. I don't know how he could say he didn't intend to do it.\"",
                    UrlSlug = seoUrlHepler.ToUrlSlug("Analysis: To convict Trump on hush money charges, prosecutors must get into his head"),
                    Published = true,
                    PostOn = DateTime.Now,
                    Modified = DateTime.Now,
                    CategoryId = 4,
                    ViewCount = 6000,
                    RateCount = 1200,
                    TotalRate = 2500,
                    Rate = 2500 / 1200
                },
                new Posts
                {
                    PostId = 10,
                    Title = "Law firm Shearman & Sterling lays off more staff",
                    ShortDescription = "Lawyers walk with their briefcases towards the federal court house in San Diego, California. REUTERS/Mike Blake",
                    PostContent = "Shearman & Sterling confirmed on Wednesday that it is conducting a new round of staff reductions, joining other U.S. law firms that have shed business professional roles in the past few months. The New York-founded firm is laying off an unspecified number of people as part of a \"global reduction of our Business Services workforce,\" a spokesperson said, describing the move as a chance to \"refine and right-size\" and \"part of a continuous review process.\"\r\n\r\nRobert Brown and Geline Midouin, who were appointed co-executive directors of Sherman & Sterling in January, said in an internal memo that the firm will inform affected people in the Americas this week and those in Europe, the Middle East, Africa and the Asia-Pacific region in the coming weeks. The reduction was first reported by legal blog Above the Law. The firm spokesperson declined to specify how many positions are being cut.\r\n\r\nShearman last week elected Adam Hakki as its new leader, which took effect April 6. The firm had previously said in March that it was accelerating Hakki's transition to replace outgoing senior partner David Beveridge.\r\n\r\nShearman is one of several big law firms to lay off employees since late last year. The firm in February cut 12 associates and 26 business services professionals in the United States, citing a need to \"align our capacity levels with existing client demands.\"\r\n\r\nLast week, technology-focused law firm Gunderson Dettmer Stough Villeneuve Franklin & Hachigian laid off 10% of attorneys, paralegals and staff in its U.S. offices. The firm, like several others that have let go of lawyers and staff, attributed the move to macroeconomic and market conditions. Firms are facing cooling demand from corporate clients as global M&A activity slows. The total value of global announced M&A deals in the first quarter of 2023 dropped 44% compared to the same period last year, shrinking to $580 billion, according to data released last week by Refinitiv.\r\n\r\nCooley, Goodwin Procter, Stroock & Stroock & Lavan, Davis Wright Tremaine, Perkins Coie and Lowenstein Sandler are among the law firms that have let go of attorneys, staff or both in recent months.\r\n\r\nThe U.S. legal services sector lost 600 jobs in March, new Labor Department figures showed last week, marking the first monthly employment decline for the industry since September.\r\n\r\nThe reduction at Shearman comes as the firm has seen at least 20 partners exit since October, especially outside of the United States.\r\n\r\nThe firm also recently ended merger talks with larger rival Hogan Lovells. ",
                    UrlSlug = seoUrlHepler.ToUrlSlug("Law firm Shearman & Sterling lays off more staff"),
                    Published = true,
                    PostOn = DateTime.Now,
                    Modified = DateTime.Now,
                    CategoryId = 4,
                    ViewCount = 400,
                    RateCount = 30,
                    TotalRate = 80,
                    Rate = 80 / 30
                },
                new Posts
                {
                    PostId = 11,
                    Title = "NHL roundup: Islanders beat Habs, clinch playoff berth",
                    ShortDescription = "Apr 12, 2023; Elmont, New York, USA; New York Islanders center Brock Nelson (29) brings the puck up ice against the Montreal Canadiens during the second period at UBS Arena. Mandatory Credit: Brad Penner-USA TODAY Sport",
                    PostContent = "April 13 - Brock Nelson scored two goals to help the New York Islanders clinch a playoff berth with a 4-2 victory over the Montreal Canadiens on Wednesday in Elmont, N.Y.\r\n\r\nHudson Fasching and captain Anders Lee also tallied and Ilya Sorokin made 17 saves for the Islanders, who won three of their final four games to move into the top wild-card spot in the Eastern Conference. Noah Dobson logged two assists. New York holds a one-point lead over the Florida Panthers, who host the Carolina Hurricanes on Thursday in their regular-season finale. Rem Pitlick and captain Nick Suzuki each scored a goal and Sam Montembeault turned aside 31 shots for the Canadiens, who have lost six of their past seven games.\r\n\r\nWith his team short-handed, Suzuki beat Islanders defenseman Samuel Bolduc to a puck and handcuffed Sorokin to trim New York's lead to 3-2 with 3:22 remaining in the second period. The goal was Suzuki's 25th of the season. Lee deflected a shot from the point to give New York a 4-2 lead with four minutes to play in the third period to seal the victory. Wyatt Johnston scored twice as visiting Dallas defeated St. Louis to aid its bid for the Central Division title.\r\n\r\nThe Stars moved into first place, one point ahead of the Colorado Avalanche. Tyler Seguin had a goal and an assist for the Stars, who won their fifth straight game. Joe Pavelski and Roope Hintz also scored, and Scott Wedgewood earned the victory with 16 saves.\r\n\r\nRobert Thomas recorded a goal and an assist for the Blues. Jakub Vrana also scored for St. Louis, and Joel Hofer made 32 saves.\r\n\r\nFlames 3, Sharks 1\r\n\r\nNikita Zadorov collected his first career hat trick and goaltender Dustin Wolf won in his NHL debut as host Calgary concluded its season by scoring three unanswered goals in a victory over San Jose.\r\n\r\nWolf, the 2019 seventh-round draft choice and third-year pro who leads the AHL in nearly every goaltending category, made 23 saves. Noah Gregor scored for the Sharks, who have lost five straight games (0-4-1). Goalie Kaapo Kahkonen made a career-high 46 saves, 21 of them in the third period. ",
                    UrlSlug = seoUrlHepler.ToUrlSlug("NHL roundup: Islanders beat Habs, clinch playoff berth"),
                    Published = true,
                    PostOn = DateTime.Now,
                    Modified = DateTime.Now,
                    CategoryId = 6,
                    ViewCount = 250,
                    RateCount = 30,
                    TotalRate = 67,
                    Rate = 67 / 30

                },
                new Posts
                {
                    PostId = 12,
                    Title = "MLB roundup: Rays make it 12 straight wins to open season",
                    ShortDescription = "St. Petersburg, Florida, USA; Tampa Bay Rays starting pitcher Taj Bradley (45) throws a pitch against the Boston Red Sox during the first inning at Tropicana Field. Mandatory Credit: Kim Klement-USA TODAY Sports",
                    PostContent = "Taj Bradley won his major league debut with five solid innings, and the Tampa Bay Rays extended their winning streak to a dozen games with a 9-7 victory over the Boston Red Sox on Wednesday in St. Petersburg, Fla.\r\n\r\nThe Rays' run of 12 consecutive victories to start the season is the third-best mark in modern-era major league history, trailing the 13-win streaks turned in by the Milwaukee Brewers (1987) and Atlanta Braves (1982). Bradley (1-0) allowed three runs and five hits while whiffing eight and walking one. Randy Arozarena stroked a three-run homer and had four RBIs for Tampa Bay, and Wander Franco had three doubles, two runs, two RBIs and a stolen base. Christian Bethancourt and Vidal Brujan each went 2-for-3.\r\n\r\nRafael Devers hit a three-run homer for the Red Sox, and Reese McGuire had three hits and two runs. Alex Verdugo, Justin Turner and Enrique Hernandez each went 2-for-4. In his third start of the season, Boston's Chris Sale (1-1) was hit hard, yielding six runs (five earned) on seven hits. He fanned six and walked two. George Springer singled in the winning run in the bottom of the 10th, and Toronto came back to defeat visiting Detroit.\r\n\r\nToronto scored two in the ninth to tie the game, two innings after Kerry Carpenter hit a two-run home run that gave Detroit a 3-1 lead in the seventh. Nick Maton had a solo shot in the fourth for the Tigers, who have lost six in a row.\r\n\r\nDetroit left-hander Eduardo Rodriguez allowed one run, seven hits and one walk in six innings, striking out three. Toronto right-hander Kevin Gausman allowed three runs and five hits while striking out 11 in eight innings, as neither starter factored into the decision. Jordan Romano (2-0) allowed only a walk in the top of the 10th to earn the win.\r\n\r\nAstros 7, Pirates 0\r\n\r\nJose Urquidy allowed two hits over six innings as Houston drubbed host Pittsburgh in the rubber match of the three-game series. Urquidy (1-0) allowed three walks and struck out two for the Astros. Alex Bregman belted a three-run homer, Corey Julks added a solo shot and Jose Abreu had an RBI double for Houston.\r\n\r\nPittsburgh starter Rich Hill (0-2) took the loss despite yielding just two runs on five hits to go along with two walks in six innings.\r\n\r\nMets 5, Padres 2\r\n\r\nBrandon Nimmo finished with three hits and two RBIs, and Tylor Megill combined with four relievers on a six-hitter for host New York, which beat San Diego to take of three in their series.\r\n\r\nFrancisco Lindor and Pete Alonso hit the tying and go-ahead solo homers while Tommy Pham had an RBI single for the Mets, who have won four of six. Megill (3-0) gave up two runs on three hits and three walks with three strikeouts in five innings.\r\n\r\nJuan Soto hit a long two-run homer in the first for the Padres, who lost a series for the first time this season.\r\n\r\nDiamondbacks 7, Brewers 3\r\n\r\nLourdes Gurriel Jr. hit a three-run homer among his three hits to lead Arizona past Milwaukee in the rubber match of a three-game series in Phoenix.\r\n\r\nDrey Jameson made his first start of the season and pitched four scoreless frames, allowing three hits and striking out four, leaving with a 5-0 lead. Kyle Nelson (2-0) picked up the win with 1 1/3 innings of scoreless relief. He fanned three.\r\n\r\nJanson Junk (0-1) made his Brewers debut while filling in for an injured Brandon Woodruff, taking the loss while going 4 2/3 innings and allowing five runs (four earned) on seven hits. He walked two and struck out two.\r\n\r\nTwins 3, White Sox 1\r\n\r\nSonny Gray pitched five shutout innings and Ryan Jeffers scored two runs to lead host Minnesota over Chicago to take two of three in the series in Minneapolis.\r\n\r\nGray (2-0) allowed three hits, walked two and struck out five while lowering his ERA to 0.53. Jhoan Duran picked up his third save.\r\n\r\nLenyn Sosa homered, and Luis Robert Jr. and Seby Zavala had doubles for the White Sox, who lost for the fifth time in seven games.\r\n\r\nYankees 4, Guardians 3\r\n\r\nOswaldo Cabrera hit a go-ahead single with one out in the ninth inning off Emmanuel Clase to lift visiting New York over Cleveland.\r\n\r\nThe Yankees' rally started when Giancarlo Stanton legged out an infield single and took second base after shortstop Amed Rosario committed a throwing error. After Clase (1-1) struck out Franchy Cordero, Cabrera roped a slider off the base of the right field wall to plate pinch runner Gleyber Torres.\r\n\r\nGuardians starter Peyton Battenfield allowed two runs (one earned) on four hits in 4 2/3 innings in his major league debut.\r\n\r\nMariners 5, Cubs 2\r\n\r\nJarred Kelenic homered for the third straight game and Teoscar Hernandez added a solo blast as visiting Seattle posted a win over Chicago.\r\n\r\nLogan Gilbert (1-1) allowed one run on four hits with seven strikeouts over 6 2/3 innings for Seattle, which avoided a three-game sweep and concluded its six-game road trip with a 3-3 mark. Ty France extended his hitting streak to 10 games with two hits and an RBI and a run.\r\n\r\nChicago trailed 5-1 before Cody Bellinger belted a solo homer against Paul Sewald in the ninth inning. Seattle took the lead for good with two runs in the third to snap Cubs starter Marcus Stroman's scoreless streak at 14 innings. Stroman (2-1) pitched six innings, giving up two runs on five hits. He walked two and struck out six.\r\n\r\nCardinals 7, Rockies 4\r\n\r\nNolan Gorman hit a tiebreaking homer in the eighth inning, Tyler O'Neill homered among his two hits, and St. Louis beat host Colorado in Denver.\r\n\r\nNolan Arenado also went deep, Paul Goldschmidt had two doubles, Andre Pallante (1-0) pitched around a blown save and Ryan Helsley earned his third save.\r\n\r\nJurickson Profar homered and Charlie Blackmon had two hits for Colorado. The Rockies finished their homestand 3-4.\r\n\r\nBraves 5, Reds 4\r\n\r\nEddie Rosario hit a go-ahead solo home run in the eighth inning to spark Atlanta to a win over visiting Cincinnati to sweep the three-game series.\r\n\r\nIt was Atlanta's first three-game series sweep of Cincinnati since 2014. Kirby Yates (1-0), who pitched one inning of scoreless relief, earned the win. A.J. Minter, who blew the save in the first game of the series, pitched a perfect ninth and picked up his second save.\r\n\r\nNeither starting pitcher factored into the decision. Cincinnati's Hunter Greene worked six innings and allowed three runs on seven hits to go along with a season-high 10 strikeouts. Atlanta's Spencer Strider pitched five innings and allowed three runs on four hits and two walks with nine strikeouts.\r\n\r\nMarlins 3, Phillies 2 (10 innings)\r\n\r\nBryan De La Cruz hit an RBI single down the first base line in the top of the 10th inning to lift Miami over host Philadelphia.\r\n\r\nDe La Cruz had three hits and two RBIs and Jorge Soler hit a solo home run for the Marlins, who won two of three in the series. Marlins starter Edward Cabrera allowed seven hits and two runs with four strikeouts and one walk in five innings. A.J. Puk (1-0) pitched two scoreless innings in relief.\r\n\r\nPhiladelphia's Bryson Stott had two hits and an RBI to extend his hitting streak to 12 games. Stott has nine multi-hit games this season for the Phillies. Gregory Soto (1-2) took the loss. The Phillies went down in order in the bottom of the 10th with the automatic runner stranded at second base.\r\n\r\nAngels 3, Nationals 2\r\n\r\nLogan O'Hoppe's RBI single in the sixth inning snapped a 2-2 tie, and four Los Angeles relievers combined for four scoreless innings on the way to a victory over Washington in Anaheim, Calif.\r\n\r\nGriffin Canning made the start on the mound for the Angels, his first major league appearance since July 2, 2021, before a stress fracture of his lower back sidelined him. He got a no-decision but pitched well, giving up two runs and five hits in five innings. He struck out four and did not walk a batter while throwing 69 pitches.\r\n\r\nAfter the Nationals took a 2-1 lead in the top of the fourth, the Angels loaded the bases with no outs in the bottom of the inning. Washington starter MacKenzie Gore nearly escaped, striking out Gio Urshela and O'Hoppe. But Brett Phillips followed with a walk, driving in a run and tying the game at 2-2.\r\n\r\nRoyals 10, Rangers 1\r\n\r\nMJ Melendez drove in three runs, Bobby Witt Jr. recorded his first three-hit night of the season and Kansas City snapped a three-game losing streak with a victory in Arlington, Texas.\r\n\r\nKansas City starter Brad Keller (2-1) impressed, limiting Texas to just one run on three hits with seven strikeouts and one walk over 6 2/3 innings. The only blemish on the night for Keller was giving up a solo homer to Nathaniel Lowe in the first inning.\r\n\r\nAfter that, KC controlled the game. The Royals scored three runs in the second inning to take a 3-1 lead, the last two coming on a two-run double by Melendez off Rangers starter Nathan Eovaldi. Eovaldi (1-2) allowed six runs on 10 hits with no walks and seven strikeouts over five innings. Rangers reliever Taylor Hearn gave up four runs in the seventh.\r\n\r\nA's 8, Orioles 4\r\n\r\nCarlos Perez had three hits, including a home run, and Oakland ended a six-game losing streak with a win at Baltimore.\r\n\r\nBrent Rooker homered, singled and had three RBIs for Oakland, which plated eight runs for the second straight game. Chad Smith (1-0) pitched two scoreless innings of relief for the win.\r\n\r\nRooker and Jace Peterson opened the Oakland eighth with singles off Keegan Akin (0-1). Cionel Perez replaced Akin and Aledmys Diaz loaded the bases with a bunt single. Jesus Aguilar's sacrifice fly put the A's ahead 5-4, and Oakland scored runs on a safety squeeze and Perez's RBI single to take control for good. ",
                    UrlSlug = seoUrlHepler.ToUrlSlug("MLB roundup: Rays make it 12 straight wins to open season"),
                    Published = true,
                    PostOn = DateTime.Now,
                    Modified = DateTime.Now,
                    CategoryId = 6,
                    ViewCount = 6000,
                    RateCount = 4000,
                    TotalRate = 8900,
                    Rate = 8900 / 4000,
                }
            );
            builder.Entity<Tags>().HasData(
                new Tags
                {
                    TagId = 1,
                    TagName = "Asia Pacific",
                    UrlSlug = seoUrlHepler.ToUrlSlug("Asia Pacific"),
                    Description = "is the part of the world near the western Pacific Ocean. The Asia-Pacific region varies in area depending on the context, but it often includes countries in East Asia, Southeast Asia, and Oceania that border the Pacific Ocean. South Asia, Mongolia, Myanmar, and the Russian Far East are generally included in a wider Asia-Pacific region",
                    Count = 1,
                },
                new Tags
                {
                    TagId = 2,
                    TagName = "United State",
                    UrlSlug = seoUrlHepler.ToUrlSlug("commonly known as the United States (U.S. or US) or America, is a country primarily located in North America. It consists of 50 states, a federal district, five major unincorporated territories, nine Minor Outlying Islands,[h] and 326 Indian reservations. The United States is the world's third-largest country by both land and total area"),
                    Description = "United State",
                    Count = 2,
                },
                new Tags
                {
                    TagId = 3,
                    TagName = "Sustainable Business",
                    UrlSlug = seoUrlHepler.ToUrlSlug("Sustainable Business"),
                    Description = "Learn the importance of purpose-driven firms through interactive, online case studies. Put your values into practice and discover how you can make a difference.",
                    Count = 3,
                },
                new Tags
                {
                    TagId = 4,
                    TagName = "Reuters Impact",
                    UrlSlug = seoUrlHepler.ToUrlSlug("Reuters Impact"),
                    Description = "The Most Important Climate Action Event in Generation. Uniting the Global Climate Leaders.",
                    Count = 3,
                },
                new Tags
                {
                    TagId = 5,
                    TagName = "Global Market Data",
                    UrlSlug = seoUrlHepler.ToUrlSlug("Global Market Data"),
                    Description = "Find the latest stock market news from every corner of the globe at Reuters.com, your online source for breaking international market and finance news.",
                    Count = 3,
                },
                new Tags
                {
                    TagId = 6,
                    TagName = "Carbon Markets",
                    UrlSlug = seoUrlHepler.ToUrlSlug("Carbon Markets"),
                    Description = "In a nutshell, carbon markets are trading systems in which carbon credits are sold and bought. One tradable carbon credit equals one tonne of carbon dioxide ...",
                    Count = 3,
                },
                new Tags
                {
                    TagId = 7,
                    TagName = "Legal Industry",
                    UrlSlug = seoUrlHepler.ToUrlSlug("Legal Industry"),
                    Description = "Find latest legal industry news from every corner of the globe at Reuters.com, your online source for breaking international news coverage.",
                    Count = 3,
                },
                new Tags
                {
                    TagId = 8,
                    TagName = "Government",
                    UrlSlug = seoUrlHepler.ToUrlSlug("Government"),
                    Description = "The government is/are expected to announce its/their tax proposals today. The minister has announced that there will be no change in government policy",
                    Count = 3,
                },
                new Tags
                {
                    TagId = 9,
                    TagName = "Disrupted",
                    UrlSlug = seoUrlHepler.ToUrlSlug("Disrupted"),
                    Description = "to prevent something, especially a system, process, or event, from continuing as usual or as expected: Heavy snow disrupted travel into the city this morning",
                    Count = 3,
                },
                new Tags
                {
                    TagId = 10,
                    TagName = "Reuters Momentum",
                    UrlSlug = seoUrlHepler.ToUrlSlug("Reuters Momentum"),
                    Description = "Located in Austin, America's new technology hub for innovation and forward thinking, Reuters MOMENTUM is where C-Suite technologists, policymakers and ",
                    Count = 3,
                },
                new Tags
                {
                    TagId = 11,
                    TagName = "Athletics",
                    UrlSlug = seoUrlHepler.ToUrlSlug("Athletics"),
                    Description = "Athletics is a group of sporting events that involves competitive running, jumping, throwing, and walking. The most common types of athletics competitions ",
                    Count = 3,
                },
                new Tags
                {
                    TagId = 12,
                    TagName = "Baseball",
                    UrlSlug = seoUrlHepler.ToUrlSlug("Baseball"),
                    Description = "Baseball is a bat-and-ball sport played between two teams of nine players each, taking turns batting and fielding. The game occurs over the course of ",
                    Count = 3,
                }
                );

            builder.Entity<PostTagMap>().HasData(
               new PostTagMap
               {
                   PostId = 1,
                   TagId = 1,
               },
               new PostTagMap
               {
                   PostId = 2,
                   TagId = 2,
               },
               new PostTagMap
               {
                   PostId = 3,
                   TagId = 3,
               },
               new PostTagMap
               {
                   PostId = 4,
                   TagId = 4,
               },
               new PostTagMap
               {
                   PostId = 5,
                   TagId = 5,
               },
               new PostTagMap
               {
                   PostId = 6,
                   TagId = 6,
               },
               new PostTagMap
               {
                   PostId = 7,
                   TagId = 7,
               },
               new PostTagMap
               {
                   PostId = 8,
                   TagId = 8,
               },
               new PostTagMap
               {
                   PostId = 9,
                   TagId = 9,
               },
               new PostTagMap
               {
                   PostId = 10,
                   TagId = 10,
               },
               new PostTagMap
               {
                   PostId = 11,
                   TagId = 11,
               },
               new PostTagMap
               {
                   PostId = 12,
                   TagId = 12,
               },
               new PostTagMap
               {
                   PostId = 9,
                   TagId = 2
               },
               new PostTagMap
               {
                   PostId = 3,
                   TagId = 1
               },
               new PostTagMap
               {
                   PostId = 6,
                   TagId = 11
               },
               new PostTagMap
               {
                   PostId = 8,
                   TagId = 4
               },
               new PostTagMap
               {
                   PostId = 1,
                   TagId = 9
               },
                new PostTagMap
                {
                    PostId = 10,
                    TagId = 6
                },
                new PostTagMap
                {
                    PostId = 5,
                    TagId = 7
                },
                new PostTagMap
                {
                    PostId = 2,
                    TagId = 10
                },
                new PostTagMap
                {
                    PostId = 11,
                    TagId = 5
                },
                new PostTagMap
                {
                    PostId = 7,
                    TagId = 3
                },
                new PostTagMap
                {
                    PostId = 4,
                    TagId = 8
                },
                new PostTagMap
                {
                    PostId = 1,
                    TagId = 4
                },
                new PostTagMap
                {
                    PostId = 11,
                    TagId = 6
                },
                new PostTagMap
                {
                    PostId = 6,
                    TagId = 1
                },
                new PostTagMap
                {
                    PostId = 3,
                    TagId = 11
                },
                new PostTagMap
                {
                    PostId = 9,
                    TagId = 10
                },
                new PostTagMap
                {
                    PostId = 2,
                    TagId = 7
                },
                new PostTagMap
                {

                    PostId = 8,
                    TagId = 12
                },
                new PostTagMap
                {
                    PostId = 5,
                    TagId = 3
                }
               );

            builder.Entity<Comments>().HasData(
                new Comments
                {
                    CommentId = 1,
                    Name = "User1",
                    Email = "user1@gmail.com",
                    PostId = 1,
                    CommentHeader = "First Comment",
                    CommentText = "Blog is good",
                    CommentTime = DateTime.Now,
                },
                new Comments
                {
                    CommentId = 2,
                    Name = "User2",
                    Email = "user2@gmail.com",
                    PostId = 2,
                    CommentHeader = "Second Comment",
                    CommentText = "Blog is OK",
                    CommentTime = DateTime.Parse("2023-02-19"),
                },
                new Comments
                {
                    CommentId = 3,
                    Name = "User3",
                    Email = "user3@gmail.com",
                    PostId = 3,
                    CommentHeader = "Final comment",
                    CommentText = "Blog so long and full",
                    CommentTime = DateTime.Now,
                }
                );
        }
    }
}
