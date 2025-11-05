interface CvTag {
    id: string;
    userId: string;
    user: object;
    name: string;
}

interface CvTagProps {
    tags: CvTag[];
}

export default function CvTagComponent({ tags }: CvTagProps) {
    return (
        <ul className="d-flex flex-wrap flex-row gap-2 justify-content-start p-0 m-0">
            {tags.map((tag, index) => (
                <li key={`${tag.id}-${index}`} className="badge bg-primary list-unstyled">
                    {tag.name}
                </li>
            ))}
        </ul>
    );
}