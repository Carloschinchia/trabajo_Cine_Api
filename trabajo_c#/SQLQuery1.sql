
use dbCine

CREATE TABLE pelicula(
 id int identity(1,1) primary key,
 nombre varchar(50) not null,
 descrision varchar(max) not null,
 precio decimal(10,3) not null,
 imagen varchar(max) not null
);



INSERT INTO [dbCine].[dbo].[pelicula]
    ([nombre], [descrision], [precio], [imagen])
VALUES
    ('Spider-Man: No Way Home',
     'Peter Parker enfrenta las consecuencias de que su identidad sea revelada al mundo.',
     14000,
     'https://m.media-amazon.com/images/M/MV5BMjMyOTM4MDMxNV5BMl5BanBnXkFtZTcwNjIyNzExOA@@._V1_FMjpg_UX1000_.jpg'),

    ('Batman: The Dark Knight',
     'Batman se enfrenta al Joker, un criminal que busca sembrar el caos en Gotham.',
     16000,
     'https://m.media-amazon.com/images/M/MV5BMmU5NGJlMzAtMGNmOC00YjJjLTgyMzUtNjAyYmE4Njg5YWMyXkEyXkFqcGc@._V1_.jpg'),

    ('Interstellar',
     'Un grupo de astronautas viaja por el espacio buscando un nuevo hogar para la humanidad.',
     13000,
     'https://mir-s3-cdn-cf.behance.net/project_modules/hd_webp/8d8f28105415493.619ded067937d.jpg'),

    ('Jurassic World',
     'Un parque de dinosaurios pierde el control de una peligrosa criatura.',
     12000,
     'https://m.media-amazon.com/images/M/MV5BNjg2NTcwYWQtYzk4NS00MTJhLWEzZjItMzIxNjk3YzlkYzU0XkEyXkFqcGc@._V1_.jpg'),

    ('Avatar',
     'Un exmarine llega a Pandora y se involucra con los habitantes de este mundo.',
     15000,
     'https://lumiere-a.akamaihd.net/v1/images/image_ccdd5962.jpeg?region=0,0,547,810'),

    ('Toy Story',
     'Un grupo de juguetes cobra vida cuando los humanos no están presentes.',
     10000,
     'https://lumiere-a.akamaihd.net/v1/images/alta_pre_int_intl_payoff_peeking_cmyk_v2_a283fa09.png'),

    ('The Conjuring',
     'Una familia se muda a una casa donde comienzan a ocurrir fenómenos paranormales.',
     11000,
     'https://www.spectatornews.com/wp-content/uploads/2015/11/WEB_conjuring-675x900.jpg'),

    ('John Wick',
     'Un antiguo asesino profesional regresa a la acción después de una tragedia personal.',
     14000,
     'https://cdng.europosters.eu/pod_public/750/263138.jpg'),

    ('Pirates of the Caribbean',
     'El capitán Jack Sparrow vive una aventura llena de piratas, tesoros y peligros.',
     12500,
     'https://m.media-amazon.com/images/M/MV5BZjY3ZGIyZGYtODY3Ny00NDVmLWJkOTgtMGRiNDdiMWJkOTc4XkEyXkFqcGc@._V1_.jpg')
   